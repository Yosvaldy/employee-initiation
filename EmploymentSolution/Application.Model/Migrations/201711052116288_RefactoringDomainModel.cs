namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactoringDomainModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmploymentAdditionalServices", "EmploymentId", "dbo.Employments");
            DropForeignKey("dbo.EmploymentCompanyAccessLevels", "EmploymentId", "dbo.Employments");
            DropForeignKey("dbo.EmploymentCompanyAccessLevels", "CompanyAccessLevelId", "dbo.CompanyAccessLevels");
            DropForeignKey("dbo.Employments", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.CompanyAccessLevels", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.CompanyAccessLevels", "AccessLevelId", "dbo.AccessLevels");
            DropIndex("dbo.EmploymentCompanyAccessLevels", new[] { "EmploymentId" });
            DropIndex("dbo.EmploymentCompanyAccessLevels", new[] { "CompanyAccessLevelId" });
            DropIndex("dbo.Employments", new[] { "EmployeeId" });
            DropIndex("dbo.EmploymentAdditionalServices", new[] { "EmploymentId" });
            RenameColumn(table: "dbo.EmploymentServices", name: "ServiceEquipment_ServiceEquipmentId", newName: "ServiceEquipmentId");
            RenameColumn(table: "dbo.EmploymentServices", name: "Employment_EmploymentId", newName: "EmploymentId");
            RenameIndex(table: "dbo.EmploymentServices", name: "IX_Employment_EmploymentId", newName: "IX_EmploymentId");
            RenameIndex(table: "dbo.EmploymentServices", name: "IX_ServiceEquipment_ServiceEquipmentId", newName: "IX_ServiceEquipmentId");
            DropPrimaryKey("dbo.Employees");
            DropPrimaryKey("dbo.EmploymentServices");
            DropPrimaryKey("dbo.CompanyAccessLevels");
            CreateTable(
                "dbo.EmploymentAccessLevels",
                c => new
                    {
                        EmploymentId = c.Int(nullable: false),
                        AccessLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmploymentId, t.AccessLevelId })
                .ForeignKey("dbo.Employments", t => t.EmploymentId, cascadeDelete: true)
                .ForeignKey("dbo.AccessLevels", t => t.AccessLevelId, cascadeDelete: true)
                .Index(t => t.EmploymentId)
                .Index(t => t.AccessLevelId);
            
            AddColumn("dbo.AccessLevels", "Description", c => c.String(maxLength: 255));
            AddColumn("dbo.Companies", "Description", c => c.String(maxLength: 255));
            AddColumn("dbo.Employments", "CompanyId", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "AdditionalService", c => c.String(maxLength: 255));
            AddColumn("dbo.Employees", "EmploymentId", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "EmployeeId", c => c.Int(nullable: false));
            AlterColumn("dbo.ServiceEquipments", "Description", c => c.String(maxLength: 255));
            AddPrimaryKey("dbo.Employees", "EmployeeId");
            AddPrimaryKey("dbo.EmploymentServices", new[] { "EmploymentId", "ServiceEquipmentId" });
            AddPrimaryKey("dbo.CompanyAccessLevels", new[] { "CompanyId", "AccessLevelId" });
            CreateIndex("dbo.Employments", "CompanyId");
            CreateIndex("dbo.Employees", "EmployeeId");
            AddForeignKey("dbo.Employments", "CompanyId", "dbo.Companies", "CompanyId", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "EmployeeId", "dbo.Employments", "EmploymentId");
            AddForeignKey("dbo.CompanyAccessLevels", "CompanyId", "dbo.Companies", "CompanyId", cascadeDelete: true);
            AddForeignKey("dbo.CompanyAccessLevels", "AccessLevelId", "dbo.AccessLevels", "AccessLevelId", cascadeDelete: true);
            DropColumn("dbo.CompanyAccessLevels", "CompanyAccessLevelId");
            DropTable("dbo.EmploymentCompanyAccessLevels");
            DropTable("dbo.EmploymentAdditionalServices");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmploymentAdditionalServices",
                c => new
                    {
                        EmploymentAdditionalServiceId = c.Int(nullable: false, identity: true),
                        EmploymentId = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.EmploymentAdditionalServiceId);
            
            CreateTable(
                "dbo.EmploymentCompanyAccessLevels",
                c => new
                    {
                        EmploymentCompanyAccessLevelId = c.Int(nullable: false, identity: true),
                        EmploymentId = c.Int(nullable: false),
                        CompanyAccessLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmploymentCompanyAccessLevelId);
            
            AddColumn("dbo.CompanyAccessLevels", "CompanyAccessLevelId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.CompanyAccessLevels", "AccessLevelId", "dbo.AccessLevels");
            DropForeignKey("dbo.CompanyAccessLevels", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Employees", "EmployeeId", "dbo.Employments");
            DropForeignKey("dbo.Employments", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.EmploymentAccessLevels", "AccessLevelId", "dbo.AccessLevels");
            DropForeignKey("dbo.EmploymentAccessLevels", "EmploymentId", "dbo.Employments");
            DropIndex("dbo.EmploymentAccessLevels", new[] { "AccessLevelId" });
            DropIndex("dbo.EmploymentAccessLevels", new[] { "EmploymentId" });
            DropIndex("dbo.Employees", new[] { "EmployeeId" });
            DropIndex("dbo.Employments", new[] { "CompanyId" });
            DropPrimaryKey("dbo.CompanyAccessLevels");
            DropPrimaryKey("dbo.EmploymentServices");
            DropPrimaryKey("dbo.Employees");
            AlterColumn("dbo.ServiceEquipments", "Description", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Employees", "EmploymentId");
            DropColumn("dbo.Employees", "AdditionalService");
            DropColumn("dbo.Employments", "CompanyId");
            DropColumn("dbo.Companies", "Description");
            DropColumn("dbo.AccessLevels", "Description");
            DropTable("dbo.EmploymentAccessLevels");
            AddPrimaryKey("dbo.CompanyAccessLevels", "CompanyAccessLevelId");
            AddPrimaryKey("dbo.EmploymentServices", new[] { "ServiceEquipment_ServiceEquipmentId", "Employment_EmploymentId" });
            AddPrimaryKey("dbo.Employees", "EmployeeId");
            RenameIndex(table: "dbo.EmploymentServices", name: "IX_ServiceEquipmentId", newName: "IX_ServiceEquipment_ServiceEquipmentId");
            RenameIndex(table: "dbo.EmploymentServices", name: "IX_EmploymentId", newName: "IX_Employment_EmploymentId");
            RenameColumn(table: "dbo.EmploymentServices", name: "EmploymentId", newName: "Employment_EmploymentId");
            RenameColumn(table: "dbo.EmploymentServices", name: "ServiceEquipmentId", newName: "ServiceEquipment_ServiceEquipmentId");
            CreateIndex("dbo.EmploymentAdditionalServices", "EmploymentId");
            CreateIndex("dbo.Employments", "EmployeeId");
            CreateIndex("dbo.EmploymentCompanyAccessLevels", "CompanyAccessLevelId");
            CreateIndex("dbo.EmploymentCompanyAccessLevels", "EmploymentId");
            AddForeignKey("dbo.CompanyAccessLevels", "AccessLevelId", "dbo.AccessLevels", "AccessLevelId");
            AddForeignKey("dbo.CompanyAccessLevels", "CompanyId", "dbo.Companies", "CompanyId");
            AddForeignKey("dbo.Employments", "EmployeeId", "dbo.Employees", "EmployeeId", cascadeDelete: true);
            AddForeignKey("dbo.EmploymentCompanyAccessLevels", "CompanyAccessLevelId", "dbo.CompanyAccessLevels", "CompanyAccessLevelId");
            AddForeignKey("dbo.EmploymentCompanyAccessLevels", "EmploymentId", "dbo.Employments", "EmploymentId");
            AddForeignKey("dbo.EmploymentAdditionalServices", "EmploymentId", "dbo.Employments", "EmploymentId");
        }
    }
}
