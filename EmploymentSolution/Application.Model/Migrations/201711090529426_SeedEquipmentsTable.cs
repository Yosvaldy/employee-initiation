namespace Application.Model.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedEquipmentsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Equipments (Name) VALUES ('Company email')");
            Sql("INSERT INTO Equipments (Name) VALUES ('Opus login')");
            Sql("INSERT INTO Equipments (Name) VALUES ('Desk')");
            Sql("INSERT INTO Equipments (Name) VALUES ('Computer')");
            Sql("INSERT INTO Equipments (Name) VALUES ('Landline extension')");
            Sql("INSERT INTO Equipments (Name) VALUES ('Company mobile phone')");
            Sql("INSERT INTO Equipments (Name) VALUES ('Company laptop')");
            Sql("INSERT INTO Equipments (Name) VALUES ('ADP (includes being enrolled in time clock)')");
            Sql("INSERT INTO Equipments (Name) VALUES ('Other')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Equipments");
        }
    }
}
