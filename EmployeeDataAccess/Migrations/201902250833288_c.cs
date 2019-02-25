namespace EmployeeDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeByDepts",
                c => new
                    {
                        EmployeeId = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.String(),
                        Sex = c.String(),
                        Email = c.String(),
                        DepartmentId = c.String(),
                        Random = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeeByDepts");
        }
    }
}
