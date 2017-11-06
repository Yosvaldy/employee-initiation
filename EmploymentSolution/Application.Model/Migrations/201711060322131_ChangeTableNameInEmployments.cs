namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTableNameInEmployments : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EmploymentsRegistation", newName: "Employments");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Employments", newName: "EmploymentsRegistation");
        }
    }
}
