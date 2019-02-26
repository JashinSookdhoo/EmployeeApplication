namespace EmployeeDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EmployeeByDepts", "Random");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeByDepts", "Random", c => c.String());
        }
    }
}
