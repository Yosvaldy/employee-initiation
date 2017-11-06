namespace Application.Model.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedEmploymentsTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO[dbo].[Employments] ([CreatedDate], [StartDate], [ManagerEmail], [PositionId], [CompanyId], [RestrictedAccess], [AdditionalInfoUserAccess], [AdditionalService], [PositionOtherDescription], [CompanyOtherDescription], [AccessLevelOtherDescription], [ServiceEquipmentOtherdescription], [FullName], [Email], [Phone]) VALUES(N'2017-12-11 00:00:00', N'2017-12-12 00:00:00', N'many@gmail.com', 1, 4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'John Smith', N'john@gmail.com', N'3056542136')
                    INSERT INTO[dbo].[Employments] ([CreatedDate], [StartDate], [ManagerEmail], [PositionId], [CompanyId], [RestrictedAccess], [AdditionalInfoUserAccess], [AdditionalService], [PositionOtherDescription], [CompanyOtherDescription], [AccessLevelOtherDescription], [ServiceEquipmentOtherdescription], [FullName], [Email], [Phone]) VALUES(N'2017-11-12 00:00:00', N'2017-12-23 00:00:00', N'many@gmail.com', 3, 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Alan Sweith', N'alan@gmail.com', N'3908764567')
                    INSERT INTO[dbo].[Employments] ([CreatedDate], [StartDate], [ManagerEmail], [PositionId], [CompanyId], [RestrictedAccess], [AdditionalInfoUserAccess], [AdditionalService], [PositionOtherDescription], [CompanyOtherDescription], [AccessLevelOtherDescription], [ServiceEquipmentOtherdescription], [FullName], [Email], [Phone]) VALUES(N'2017-11-12 00:00:00', N'2017-12-12 00:00:00', N'many@gmail.com', 5, 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Steve Sthart', N'steve@gmail.com', N'4562347890')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
