namespace Application.Model.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedEmploymentAccessLevelsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO EmploymentAccessLevels (EmploymentId, AccessLevelId) VALUES (1, 1)");
            Sql("INSERT INTO EmploymentAccessLevels (EmploymentId, AccessLevelId) VALUES (1, 2)");
            Sql("INSERT INTO EmploymentAccessLevels (EmploymentId, AccessLevelId) VALUES (1, 5)");
            Sql("INSERT INTO EmploymentAccessLevels (EmploymentId, AccessLevelId) VALUES (2, 2)");
            Sql("INSERT INTO EmploymentAccessLevels (EmploymentId, AccessLevelId) VALUES (2, 7)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM EmploymentAccessLevels");
        }
    }
}
