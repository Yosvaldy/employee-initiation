namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactoringEmploymentAndEmployeeTables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Employments", newName: "EmploymentsRegistation");
            AddColumn("dbo.EmploymentsRegistation", "RestrictedAccess", c => c.String(maxLength: 255));
            AddColumn("dbo.EmploymentsRegistation", "AdditionalInfoUserAccess", c => c.String(maxLength: 255));
            AddColumn("dbo.EmploymentsRegistation", "AdditionalService", c => c.String(maxLength: 255));
            AddColumn("dbo.EmploymentsRegistation", "PositionOtherDescription", c => c.String(maxLength: 255));
            AddColumn("dbo.EmploymentsRegistation", "CompanyOtherDescription", c => c.String(maxLength: 255));
            AddColumn("dbo.EmploymentsRegistation", "AccessLevelOtherDescription", c => c.String(maxLength: 255));
            AddColumn("dbo.EmploymentsRegistation", "ServiceEquipmentOtherdescription", c => c.String(maxLength: 255));
            DropColumn("dbo.Employees", "RestrictedAccess");
            DropColumn("dbo.Employees", "AdditionalInfoUserAccess");
            DropColumn("dbo.Employees", "AdditionalService");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "AdditionalService", c => c.String(maxLength: 255));
            AddColumn("dbo.Employees", "AdditionalInfoUserAccess", c => c.String(maxLength: 255));
            AddColumn("dbo.Employees", "RestrictedAccess", c => c.String(maxLength: 255));
            DropColumn("dbo.EmploymentsRegistation", "ServiceEquipmentOtherdescription");
            DropColumn("dbo.EmploymentsRegistation", "AccessLevelOtherDescription");
            DropColumn("dbo.EmploymentsRegistation", "CompanyOtherDescription");
            DropColumn("dbo.EmploymentsRegistation", "PositionOtherDescription");
            DropColumn("dbo.EmploymentsRegistation", "AdditionalService");
            DropColumn("dbo.EmploymentsRegistation", "AdditionalInfoUserAccess");
            DropColumn("dbo.EmploymentsRegistation", "RestrictedAccess");
            RenameTable(name: "dbo.EmploymentsRegistation", newName: "Employments");
        }
    }
}
