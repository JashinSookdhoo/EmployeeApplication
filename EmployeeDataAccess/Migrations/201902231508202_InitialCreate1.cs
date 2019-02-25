namespace EmployeeDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Random", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Random");
        }
    }
}
