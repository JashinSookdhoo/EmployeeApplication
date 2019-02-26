using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeeDataAccess;
using EmployeeModel;

namespace EmployeeApplication.Controllers
{
    public class EmployeeByDeptsController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        // GET: EmployeeByDepts
        public ActionResult Index()
        {
            ViewBag.DepartmentId = new SelectList(new Models.DepartmentModel().GetAll(), "DepartmentId", "Description");
            return View(new Models.EmployeeByDeptModel().GetByDept(null));
        }
        [HttpPost]
        public ActionResult Index(string DepartmentId)
        {
            ViewBag.DepartmentId = new SelectList(new Models.DepartmentModel().GetAll(), "DepartmentId", "Description");
            return View(new Models.EmployeeByDeptModel().GetByDept(DepartmentId));
        }
        
        // GET: EmployeeByDepts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeByDept employeeByDept = db.EmployeeByDepts.Find(id);
            if (employeeByDept == null)
            {
                return HttpNotFound();
            }
            return View(employeeByDept);
        }

        // GET: EmployeeByDepts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeByDepts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeId,FirstName,LastName,DateOfBirth,Sex,Email,DepartmentId,Random,Description")] EmployeeByDept employeeByDept)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeByDepts.Add(employeeByDept);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeByDept);
        }

        // GET: EmployeeByDepts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeByDept employeeByDept = db.EmployeeByDepts.Find(id);
            if (employeeByDept == null)
            {
                return HttpNotFound();
            }
            return View(employeeByDept);
        }

        // POST: EmployeeByDepts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeId,FirstName,LastName,DateOfBirth,Sex,Email,DepartmentId,Random,Description")] EmployeeByDept employeeByDept)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeByDept).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeByDept);
        }

        // GET: EmployeeByDepts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeByDept employeeByDept = db.EmployeeByDepts.Find(id);
            if (employeeByDept == null)
            {
                return HttpNotFound();
            }
            return View(employeeByDept);
        }

        // POST: EmployeeByDepts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            EmployeeByDept employeeByDept = db.EmployeeByDepts.Find(id);
            db.EmployeeByDepts.Remove(employeeByDept);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
