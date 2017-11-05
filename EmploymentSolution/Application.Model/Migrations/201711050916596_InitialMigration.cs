namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccessLevels",
                c => new
                    {
                        AccessLevelId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.AccessLevelId);
            
            CreateTable(
                "dbo.CompanyAccessLevels",
                c => new
                    {
                        CompanyAccessLevelId = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        AccessLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyAccessLevelId)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .ForeignKey("dbo.AccessLevels", t => t.AccessLevelId)
                .Index(t => t.CompanyId)
                .Index(t => t.AccessLevelId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.EmploymentCompanyAccessLevels",
                c => new
                    {
                        EmploymentCompanyAccessLevelId = c.Int(nullable: false, identity: true),
                        EmploymentId = c.Int(nullable: false),
                        CompanyAccessLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmploymentCompanyAccessLevelId)
                .ForeignKey("dbo.Employments", t => t.EmploymentId)
                .ForeignKey("dbo.CompanyAccessLevels", t => t.CompanyAccessLevelId)
                .Index(t => t.EmploymentId)
                .Index(t => t.CompanyAccessLevelId);
            
            CreateTable(
                "dbo.Employments",
                c => new
                    {
                        EmploymentId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        ManagerEmail = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.EmploymentId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.EmploymentAdditionalServices",
                c => new
                    {
                        EmploymentAdditionalServiceId = c.Int(nullable: false, identity: true),
                        EmploymentId = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.EmploymentAdditionalServiceId)
                .ForeignKey("dbo.Employments", t => t.EmploymentId)
                .Index(t => t.EmploymentId);
            
            CreateTable(
                "dbo.EmploymentOtherPositions",
                c => new
                    {
                        EmploymentOtherPositionId = c.Int(nullable: false, identity: true),
                        EmploymentId = c.Int(nullable: false),
                        Description = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.EmploymentOtherPositionId)
                .ForeignKey("dbo.Employments", t => t.EmploymentId)
                .Index(t => t.EmploymentId);
            
            CreateTable(
                "dbo.EmploymentPositions",
                c => new
                    {
                        EmploymentPositionId = c.Int(nullable: false, identity: true),
                        EmploymentId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmploymentPositionId)
                .ForeignKey("dbo.Positions", t => t.PositionId)
                .ForeignKey("dbo.Employments", t => t.EmploymentId)
                .Index(t => t.EmploymentId)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PositionId);
            
            CreateTable(
                "dbo.EmploymentServiceEquipments",
                c => new
                    {
                        EmploymentServiceEquipmentId = c.Int(nullable: false, identity: true),
                        ServiceEquipmentId = c.Int(nullable: false),
                        EmploymentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmploymentServiceEquipmentId)
                .ForeignKey("dbo.ServiceEquipments", t => t.ServiceEquipmentId)
                .ForeignKey("dbo.Employments", t => t.EmploymentId)
                .Index(t => t.ServiceEquipmentId)
                .Index(t => t.EmploymentId);
            
            CreateTable(
                "dbo.ServiceEquipments",
                c => new
                    {
                        ServiceEquipmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ServiceEquipmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompanyAccessLevels", "AccessLevelId", "dbo.AccessLevels");
            DropForeignKey("dbo.EmploymentCompanyAccessLevels", "CompanyAccessLevelId", "dbo.CompanyAccessLevels");
            DropForeignKey("dbo.EmploymentServiceEquipments", "EmploymentId", "dbo.Employments");
            DropForeignKey("dbo.EmploymentServiceEquipments", "ServiceEquipmentId", "dbo.ServiceEquipments");
            DropForeignKey("dbo.EmploymentPositions", "EmploymentId", "dbo.Employments");
            DropForeignKey("dbo.EmploymentPositions", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.EmploymentOtherPositions", "EmploymentId", "dbo.Employments");
            DropForeignKey("dbo.EmploymentCompanyAccessLevels", "EmploymentId", "dbo.Employments");
            DropForeignKey("dbo.EmploymentAdditionalServices", "EmploymentId", "dbo.Employments");
            DropForeignKey("dbo.Employments", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.CompanyAccessLevels", "CompanyId", "dbo.Companies");
            DropIndex("dbo.EmploymentServiceEquipments", new[] { "EmploymentId" });
            DropIndex("dbo.EmploymentServiceEquipments", new[] { "ServiceEquipmentId" });
            DropIndex("dbo.EmploymentPositions", new[] { "PositionId" });
            DropIndex("dbo.EmploymentPositions", new[] { "EmploymentId" });
            DropIndex("dbo.EmploymentOtherPositions", new[] { "EmploymentId" });
            DropIndex("dbo.EmploymentAdditionalServices", new[] { "EmploymentId" });
            DropIndex("dbo.Employments", new[] { "EmployeeId" });
            DropIndex("dbo.EmploymentCompanyAccessLevels", new[] { "CompanyAccessLevelId" });
            DropIndex("dbo.EmploymentCompanyAccessLevels", new[] { "EmploymentId" });
            DropIndex("dbo.CompanyAccessLevels", new[] { "AccessLevelId" });
            DropIndex("dbo.CompanyAccessLevels", new[] { "CompanyId" });
            DropTable("dbo.ServiceEquipments");
            DropTable("dbo.EmploymentServiceEquipments");
            DropTable("dbo.Positions");
            DropTable("dbo.EmploymentPositions");
            DropTable("dbo.EmploymentOtherPositions");
            DropTable("dbo.EmploymentAdditionalServices");
            DropTable("dbo.Employees");
            DropTable("dbo.Employments");
            DropTable("dbo.EmploymentCompanyAccessLevels");
            DropTable("dbo.Companies");
            DropTable("dbo.CompanyAccessLevels");
            DropTable("dbo.AccessLevels");
        }
    }
}
