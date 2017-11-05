namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDescriptionColumnFromSomeTables : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AccessLevels", "Description");
            DropColumn("dbo.Companies", "Description");
            DropColumn("dbo.Positions", "Description");
            DropColumn("dbo.ServiceEquipments", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ServiceEquipments", "Description", c => c.String(maxLength: 255));
            AddColumn("dbo.Positions", "Description", c => c.String(maxLength: 255));
            AddColumn("dbo.Companies", "Description", c => c.String(maxLength: 255));
            AddColumn("dbo.AccessLevels", "Description", c => c.String(maxLength: 255));
        }
    }
}
