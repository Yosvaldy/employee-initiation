namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRestrictedAndAdditionalInfoAccessInEmployeeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "RestrictedAccess", c => c.String(maxLength: 255));
            AddColumn("dbo.Employees", "AdditionalInfoUserAccess", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "AdditionalInfoUserAccess");
            DropColumn("dbo.Employees", "RestrictedAccess");
        }
    }
}
