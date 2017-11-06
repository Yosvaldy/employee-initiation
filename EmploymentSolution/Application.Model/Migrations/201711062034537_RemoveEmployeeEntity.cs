namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveEmployeeEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "EmployeeId", "dbo.Employments");
            DropIndex("dbo.Employees", new[] { "EmployeeId" });
            AddColumn("dbo.Employments", "FullName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Employments", "Email", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Employments", "Phone", c => c.String(nullable: false, maxLength: 10));
            DropColumn("dbo.Employments", "EmployeeId");
            DropTable("dbo.Employees");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 10),
                        EmploymentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            AddColumn("dbo.Employments", "EmployeeId", c => c.Int(nullable: false));
            DropColumn("dbo.Employments", "Phone");
            DropColumn("dbo.Employments", "Email");
            DropColumn("dbo.Employments", "FullName");
            CreateIndex("dbo.Employees", "EmployeeId");
            AddForeignKey("dbo.Employees", "EmployeeId", "dbo.Employments", "EmploymentId");
        }
    }
}
