namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedEmploymentAccessesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO EmploymentAccesses (EmploymentId, AccessId) VALUES (1, 1)");
            Sql("INSERT INTO EmploymentAccesses (EmploymentId, AccessId) VALUES (1, 2)");
            Sql("INSERT INTO EmploymentAccesses (EmploymentId, AccessId) VALUES (2, 1)");
            Sql("INSERT INTO EmploymentAccesses (EmploymentId, AccessId) VALUES (5, 2)");
            Sql("INSERT INTO EmploymentAccesses (EmploymentId, AccessId) VALUES (5, 3)");
            Sql("INSERT INTO EmploymentAccesses (EmploymentId, AccessId) VALUES (12, 1)");
            Sql("INSERT INTO EmploymentAccesses (EmploymentId, AccessId) VALUES (12, 2)");
            Sql("INSERT INTO EmploymentAccesses (EmploymentId, AccessId) VALUES (12, 3)");
            Sql("INSERT INTO EmploymentAccesses (EmploymentId, AccessId) VALUES (12, 9)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM EmploymentAccesses");
        }
    }
}
