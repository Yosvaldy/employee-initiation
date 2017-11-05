namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAccessLevelsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AccessLevels (Name) VALUES ('Headquarters, Call Center - building 200')");
            Sql("INSERT INTO AccessLevels (Name) VALUES ('Headquarters, Main Building - building 300')");
            Sql("INSERT INTO AccessLevels (Name) VALUES ('Headquarters, Treatment - building 400')");
            Sql("INSERT INTO AccessLevels (Name) VALUES ('IT & Opus Behavioral Offices')");
            Sql("INSERT INTO AccessLevels (Name) VALUES ('Detox Housing - Building 9198')");
            Sql("INSERT INTO AccessLevels (Name) VALUES ('Focus - Buildings 895/901')");
            Sql("INSERT INTO AccessLevels (Name) VALUES ('Residence')");
            Sql("INSERT INTO AccessLevels (Name) VALUES ('Treatment')");
            Sql("INSERT INTO AccessLevels (Name) VALUES ('Treatment Housing & Administrative - buildings 9200/9280 (define special access below)')");
        }

        public override void Down()
        {
            Sql("DELETE FROM AccessLevels");
        }
    }
}
