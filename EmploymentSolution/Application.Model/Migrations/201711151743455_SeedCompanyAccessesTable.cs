namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCompanyAccessesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (1, 1)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (1, 2)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (1, 10)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (2, 7)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (2, 8)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (2, 10)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (4, 1)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (4, 2)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (4, 3)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (4, 4)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (4, 5)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (4, 6)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (4, 9)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (4, 10)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (12, 1)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (12, 2)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (12, 3)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (12, 4)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (12, 5)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (12, 6)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (12, 9)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (12, 10)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (13, 7)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (13, 8)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (13, 10)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (16, 1)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (16, 2)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (16, 3)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (16, 4)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (16, 5)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (16, 6)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (16, 7)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (16, 8)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (16, 9)");
            Sql("INSERT INTO CompanyAccesses (CompanyId, AccessId) VALUES (16, 10)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM CompanyAccesses");
        }
    }
}
