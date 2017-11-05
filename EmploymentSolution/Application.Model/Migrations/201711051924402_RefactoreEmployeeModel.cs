namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactoreEmployeeModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employments", "EmployeeId", "dbo.Employees");
            AddForeignKey("dbo.Employments", "EmployeeId", "dbo.Employees", "EmployeeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employments", "EmployeeId", "dbo.Employees");
            AddForeignKey("dbo.Employments", "EmployeeId", "dbo.Employees", "EmployeeId");
        }
    }
}
