namespace Application.Model.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedAccessesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Accesses (Name) VALUES ('Headquarters, Call Center - building 200')");
            Sql("INSERT INTO Accesses (Name) VALUES ('Headquarters, Main Building - building 300')");
            Sql("INSERT INTO Accesses (Name) VALUES ('Headquarters, Treatment - building 400')");
            Sql("INSERT INTO Accesses (Name) VALUES ('IT & Opus Behavioral Offices')");
            Sql("INSERT INTO Accesses (Name) VALUES ('Detox Housing - Building 9198')");
            Sql("INSERT INTO Accesses (Name) VALUES ('Focus - Buildings 895/901')");
            Sql("INSERT INTO Accesses (Name) VALUES ('Residence')");
            Sql("INSERT INTO Accesses (Name) VALUES ('Treatment')");
            Sql("INSERT INTO Accesses (Name) VALUES ('Treatment Housing & Administrative - buildings 9200/9280 (define special access below)')");
            Sql("INSERT INTO Accesses (Name) VALUES ('Other')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Accesses");
        }
    }
}
