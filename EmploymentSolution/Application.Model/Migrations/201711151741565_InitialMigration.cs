namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompanyAccesses",
                c => new
                    {
                        CompanyId = c.Int(nullable: false),
                        AccessId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CompanyId, t.AccessId })
                .ForeignKey("dbo.Accesses", t => t.AccessId, cascadeDelete: true)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId)
                .Index(t => t.AccessId);
            
            CreateTable(
                "dbo.Employments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 10),
                        CreatedDate = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        ManagerEmail = c.String(nullable: false, maxLength: 100),
                        RestrictedAccess = c.String(maxLength: 255),
                        AdditionalInfo = c.String(maxLength: 255),
                        AdditionalService = c.String(maxLength: 255),
                        OtherPosition = c.String(maxLength: 255),
                        OtherCompany = c.String(maxLength: 255),
                        OtherAccesses = c.String(maxLength: 255),
                        OtherServices = c.String(maxLength: 255),
                        CompanyId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.CompanyId)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.EmploymentAccesses",
                c => new
                    {
                        EmploymentId = c.Int(nullable: false),
                        AccessId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmploymentId, t.AccessId })
                .ForeignKey("dbo.Accesses", t => t.AccessId, cascadeDelete: true)
                .ForeignKey("dbo.Employments", t => t.EmploymentId, cascadeDelete: true)
                .Index(t => t.EmploymentId)
                .Index(t => t.AccessId);
            
            CreateTable(
                "dbo.EmploymentEquipments",
                c => new
                    {
                        EmploymentId = c.Int(nullable: false),
                        EquipmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmploymentId, t.EquipmentId })
                .ForeignKey("dbo.Employments", t => t.EmploymentId, cascadeDelete: true)
                .ForeignKey("dbo.Equipments", t => t.EquipmentId, cascadeDelete: true)
                .Index(t => t.EmploymentId)
                .Index(t => t.EquipmentId);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employments", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.EmploymentEquipments", "EquipmentId", "dbo.Equipments");
            DropForeignKey("dbo.EmploymentEquipments", "EmploymentId", "dbo.Employments");
            DropForeignKey("dbo.Employments", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.EmploymentAccesses", "EmploymentId", "dbo.Employments");
            DropForeignKey("dbo.EmploymentAccesses", "AccessId", "dbo.Accesses");
            DropForeignKey("dbo.CompanyAccesses", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.CompanyAccesses", "AccessId", "dbo.Accesses");
            DropIndex("dbo.EmploymentEquipments", new[] { "EquipmentId" });
            DropIndex("dbo.EmploymentEquipments", new[] { "EmploymentId" });
            DropIndex("dbo.EmploymentAccesses", new[] { "AccessId" });
            DropIndex("dbo.EmploymentAccesses", new[] { "EmploymentId" });
            DropIndex("dbo.Employments", new[] { "PositionId" });
            DropIndex("dbo.Employments", new[] { "CompanyId" });
            DropIndex("dbo.CompanyAccesses", new[] { "AccessId" });
            DropIndex("dbo.CompanyAccesses", new[] { "CompanyId" });
            DropTable("dbo.Positions");
            DropTable("dbo.Equipments");
            DropTable("dbo.EmploymentEquipments");
            DropTable("dbo.EmploymentAccesses");
            DropTable("dbo.Employments");
            DropTable("dbo.CompanyAccesses");
            DropTable("dbo.Companies");
            DropTable("dbo.Accesses");
        }
    }
}
