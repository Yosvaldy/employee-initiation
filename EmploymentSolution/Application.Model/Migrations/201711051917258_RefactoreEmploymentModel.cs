namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactoreEmploymentModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmploymentOtherPositions", "EmploymentId", "dbo.Employments");
            DropForeignKey("dbo.EmploymentPositions", "EmploymentId", "dbo.Employments");
            DropIndex("dbo.EmploymentOtherPositions", new[] { "EmploymentId" });
            AddColumn("dbo.Employments", "PositionId", c => c.Int(nullable: false));
            AddColumn("dbo.Positions", "Description", c => c.String(maxLength: 255));
            CreateIndex("dbo.Employments", "PositionId");
            AddForeignKey("dbo.Employments", "PositionId", "dbo.Positions", "PositionId", cascadeDelete: true);
            AddForeignKey("dbo.EmploymentPositions", "EmploymentId", "dbo.Employments", "EmploymentId", cascadeDelete: true);
            DropTable("dbo.EmploymentOtherPositions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmploymentOtherPositions",
                c => new
                    {
                        EmploymentOtherPositionId = c.Int(nullable: false, identity: true),
                        EmploymentId = c.Int(nullable: false),
                        Description = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.EmploymentOtherPositionId);
            
            DropForeignKey("dbo.EmploymentPositions", "EmploymentId", "dbo.Employments");
            DropForeignKey("dbo.Employments", "PositionId", "dbo.Positions");
            DropIndex("dbo.Employments", new[] { "PositionId" });
            DropColumn("dbo.Positions", "Description");
            DropColumn("dbo.Employments", "PositionId");
            CreateIndex("dbo.EmploymentOtherPositions", "EmploymentId");
            AddForeignKey("dbo.EmploymentPositions", "EmploymentId", "dbo.Employments", "EmploymentId");
            AddForeignKey("dbo.EmploymentOtherPositions", "EmploymentId", "dbo.Employments", "EmploymentId");
        }
    }
}
