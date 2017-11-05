namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactorePositionModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmploymentPositions", "EmploymentId", "dbo.Employments");
            DropForeignKey("dbo.EmploymentPositions", "PositionId", "dbo.Positions");
            DropIndex("dbo.EmploymentPositions", new[] { "EmploymentId" });
            DropIndex("dbo.EmploymentPositions", new[] { "PositionId" });
            DropTable("dbo.EmploymentPositions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmploymentPositions",
                c => new
                    {
                        EmploymentPositionId = c.Int(nullable: false, identity: true),
                        EmploymentId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmploymentPositionId);
            
            CreateIndex("dbo.EmploymentPositions", "PositionId");
            CreateIndex("dbo.EmploymentPositions", "EmploymentId");
            AddForeignKey("dbo.EmploymentPositions", "PositionId", "dbo.Positions", "PositionId");
            AddForeignKey("dbo.EmploymentPositions", "EmploymentId", "dbo.Employments", "EmploymentId", cascadeDelete: true);
        }
    }
}
