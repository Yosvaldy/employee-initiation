namespace Application.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedEmploymentEquipmentsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (1, 1)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (1, 4)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (2, 3)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (2, 6)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (3, 7)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (4, 2)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (4, 6)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (4, 7)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (5, 3)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (5, 5)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (6, 7)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (7, 3)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (8, 3)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (8, 8)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (9, 3)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (10, 4)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (11, 2)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (12, 6)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (13, 7)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (14, 4)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (14, 7)");
            Sql("INSERT INTO EmploymentEquipments (EmploymentId, EquipmentId) VALUES (15, 8)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM EmploymentEquipments");
        }
    }
}
