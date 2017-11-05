namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedServiceEquipmentsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ServiceEquipments (Name) VALUES ('Company email')");
            Sql("INSERT INTO ServiceEquipments (Name) VALUES ('Opus login')");
            Sql("INSERT INTO ServiceEquipments (Name) VALUES ('Desk')");
            Sql("INSERT INTO ServiceEquipments (Name) VALUES ('Computer')");
            Sql("INSERT INTO ServiceEquipments (Name) VALUES ('Landline extension')");
            Sql("INSERT INTO ServiceEquipments (Name) VALUES ('Company mobile phone')");
            Sql("INSERT INTO ServiceEquipments (Name) VALUES ('Company laptop')");
            Sql("INSERT INTO ServiceEquipments (Name) VALUES ('ADP (includes being enrolled in time clock)')");
            Sql("INSERT INTO ServiceEquipments (Name) VALUES ('Other')");
        }

        public override void Down()
        {
            Sql("DELETE FROM ServiceEquipments");
        }
    }
}
