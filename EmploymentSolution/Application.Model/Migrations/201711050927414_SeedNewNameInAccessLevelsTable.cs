namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedNewNameInAccessLevelsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AccessLevels (Name) VALUES ('Other')");
        }

        public override void Down()
        {
            Sql("DELETE FROM AccessLevels WHERE Name = 'Other'");
        }
    }
}
