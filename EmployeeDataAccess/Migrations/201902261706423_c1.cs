namespace EmployeeDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "Random");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Random", c => c.String());
        }
    }
}
