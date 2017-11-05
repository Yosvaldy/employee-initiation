namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactoreServiceEquipmentModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmploymentServiceEquipments", "ServiceEquipmentId", "dbo.ServiceEquipments");
            DropForeignKey("dbo.EmploymentServiceEquipments", "EmploymentId", "dbo.Employments");
            DropIndex("dbo.EmploymentServiceEquipments", new[] { "ServiceEquipmentId" });
            DropIndex("dbo.EmploymentServiceEquipments", new[] { "EmploymentId" });
            CreateTable(
                "dbo.EmploymentServices",
                c => new
                    {
                        ServiceEquipment_ServiceEquipmentId = c.Int(nullable: false),
                        Employment_EmploymentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ServiceEquipment_ServiceEquipmentId, t.Employment_EmploymentId })
                .ForeignKey("dbo.ServiceEquipments", t => t.ServiceEquipment_ServiceEquipmentId, cascadeDelete: true)
                .ForeignKey("dbo.Employments", t => t.Employment_EmploymentId, cascadeDelete: true)
                .Index(t => t.ServiceEquipment_ServiceEquipmentId)
                .Index(t => t.Employment_EmploymentId);
            
            AddColumn("dbo.ServiceEquipments", "Description", c => c.String());
            DropTable("dbo.EmploymentServiceEquipments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmploymentServiceEquipments",
                c => new
                    {
                        EmploymentServiceEquipmentId = c.Int(nullable: false, identity: true),
                        ServiceEquipmentId = c.Int(nullable: false),
                        EmploymentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmploymentServiceEquipmentId);
            
            DropForeignKey("dbo.EmploymentServices", "Employment_EmploymentId", "dbo.Employments");
            DropForeignKey("dbo.EmploymentServices", "ServiceEquipment_ServiceEquipmentId", "dbo.ServiceEquipments");
            DropIndex("dbo.EmploymentServices", new[] { "Employment_EmploymentId" });
            DropIndex("dbo.EmploymentServices", new[] { "ServiceEquipment_ServiceEquipmentId" });
            DropColumn("dbo.ServiceEquipments", "Description");
            DropTable("dbo.EmploymentServices");
            CreateIndex("dbo.EmploymentServiceEquipments", "EmploymentId");
            CreateIndex("dbo.EmploymentServiceEquipments", "ServiceEquipmentId");
            AddForeignKey("dbo.EmploymentServiceEquipments", "EmploymentId", "dbo.Employments", "EmploymentId");
            AddForeignKey("dbo.EmploymentServiceEquipments", "ServiceEquipmentId", "dbo.ServiceEquipments", "ServiceEquipmentId");
        }
    }
}
