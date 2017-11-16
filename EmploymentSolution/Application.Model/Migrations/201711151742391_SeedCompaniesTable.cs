namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCompaniesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Companies (Name) VALUES ('Addiction Recovery Now')");
            Sql("INSERT INTO Companies (Name) VALUES ('Comfort Recovery')");
            Sql("INSERT INTO Companies (Name) VALUES ('Discovery Point Retreat')");
            Sql("INSERT INTO Companies (Name) VALUES ('Harbor Village')");
            Sql("INSERT INTO Companies (Name) VALUES ('Hope Canyon Recovery')");
            Sql("INSERT INTO Companies (Name) VALUES ('Niznik Behavioral Health')");
            Sql("INSERT INTO Companies (Name) VALUES ('Niznik Behavioral Health Resources')");
            Sql("INSERT INTO Companies (Name) VALUES ('Niznik Lab Corp')");
            Sql("INSERT INTO Companies (Name) VALUES ('Palms Detox')");
            Sql("INSERT INTO Companies (Name) VALUES ('Paradise Detox')");
            Sql("INSERT INTO Companies (Name) VALUES ('Opus Behavioral Health')");
            Sql("INSERT INTO Companies (Name) VALUES ('Rx Universal')");
            Sql("INSERT INTO Companies (Name) VALUES ('Safe Landing Recovery')");
            Sql("INSERT INTO Companies (Name) VALUES ('U.S. Billing Resources')");
            Sql("INSERT INTO Companies (Name) VALUES ('U.S. Health Corp Lab')");
            Sql("INSERT INTO Companies (Name) VALUES ('Other')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Companies");
        }
    }
}
