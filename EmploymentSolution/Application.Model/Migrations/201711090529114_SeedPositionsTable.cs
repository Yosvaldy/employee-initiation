namespace Application.Model.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedPositionsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Positions (Name) VALUES ('Behavioral Health Technician (BHT)')");
            Sql("INSERT INTO Positions (Name) VALUES ('Call Center')");
            Sql("INSERT INTO Positions (Name) VALUES ('Case Manager')");
            Sql("INSERT INTO Positions (Name) VALUES ('Licensed Practical Nurse (LPN or LVN)')");
            Sql("INSERT INTO Positions (Name) VALUES ('Massage Therapist')");
            Sql("INSERT INTO Positions (Name) VALUES ('Medical Assistant')");
            Sql("INSERT INTO Positions (Name) VALUES ('Marketing')");
            Sql("INSERT INTO Positions (Name) VALUES ('Medical Doctor')");
            Sql("INSERT INTO Positions (Name) VALUES ('Nurse Practitioner')");
            Sql("INSERT INTO Positions (Name) VALUES ('Physician')");
            Sql("INSERT INTO Positions (Name) VALUES ('Recovery Coach')");
            Sql("INSERT INTO Positions (Name) VALUES ('Registered Nurse (RN)')");
            Sql("INSERT INTO Positions (Name) VALUES ('Therapist')");
            Sql("INSERT INTO Positions (Name) VALUES ('Accounting')");
            Sql("INSERT INTO Positions (Name) VALUES ('Administrative, Corporate or Executive')");
            Sql("INSERT INTO Positions (Name) VALUES ('Other')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Positions");
        }
    }
}
