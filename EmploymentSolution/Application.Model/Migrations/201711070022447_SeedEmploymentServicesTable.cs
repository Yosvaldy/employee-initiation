namespace Application.Model.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedEmploymentServicesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO EmploymentServices (ServiceEquipmentId, EmploymentId) VALUES (1, 1)");
            Sql("INSERT INTO EmploymentServices (ServiceEquipmentId, EmploymentId) VALUES (3, 1)");
            Sql("INSERT INTO EmploymentServices (ServiceEquipmentId, EmploymentId) VALUES (4, 1)");
            Sql("INSERT INTO EmploymentServices (ServiceEquipmentId, EmploymentId) VALUES (6, 1)");
            Sql("INSERT INTO EmploymentServices (ServiceEquipmentId, EmploymentId) VALUES (7, 1)");
            Sql("INSERT INTO EmploymentServices (ServiceEquipmentId, EmploymentId) VALUES (1, 2)");
            Sql("INSERT INTO EmploymentServices (ServiceEquipmentId, EmploymentId) VALUES (2, 2)");
            Sql("INSERT INTO EmploymentServices (ServiceEquipmentId, EmploymentId) VALUES (4, 2)");
            Sql("INSERT INTO EmploymentServices (ServiceEquipmentId, EmploymentId) VALUES (6, 2)");
            Sql("INSERT INTO EmploymentServices (ServiceEquipmentId, EmploymentId) VALUES (8, 2)");
            Sql("INSERT INTO EmploymentServices (ServiceEquipmentId, EmploymentId) VALUES (3, 3)");
            Sql("INSERT INTO EmploymentServices (ServiceEquipmentId, EmploymentId) VALUES (5, 3)");
            Sql("INSERT INTO EmploymentServices (ServiceEquipmentId, EmploymentId) VALUES (6, 3)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM EmploymentServices");
        }
    }
}
