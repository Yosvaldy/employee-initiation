namespace Application.Model
{
    using Entities;
    using EntityConfiguration;
    using System.Data.Entity;

    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=AppModel")
        {
        }

        public virtual DbSet<AccessLevel> AccessLevels { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Employment> Employments { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<ServiceEquipment> ServiceEquipments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccessLevelConfiguration());
            modelBuilder.Configurations.Add(new CompanyConfiguration());
            modelBuilder.Configurations.Add(new EmploymentConfiguration());
            modelBuilder.Configurations.Add(new PositionConfiguration());
            modelBuilder.Configurations.Add(new ServiceEquipmentConfiguration());
        }
    }
}
