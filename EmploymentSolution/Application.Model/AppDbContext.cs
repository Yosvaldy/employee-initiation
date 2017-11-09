namespace Application.Model
{
    using Entities;
    using EntityConfiguration;
    using System.Data.Entity;

    public partial class AppDbContext : DbContext
    {
        public virtual DbSet<Access> Accesses { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Employment> Employments { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }

        public AppDbContext()
            : base("name=AppModel")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccessConfiguration());
            modelBuilder.Configurations.Add(new CompanyConfiguration());
            modelBuilder.Configurations.Add(new EmploymentConfiguration());
            modelBuilder.Configurations.Add(new PositionConfiguration());
            modelBuilder.Configurations.Add(new EquipmentConfiguration());
            modelBuilder.Configurations.Add(new EmploymentEquipmentConfiguration());
            modelBuilder.Configurations.Add(new EmploymentAccessConfiguration());
            modelBuilder.Configurations.Add(new CompanyAccessesConfiguration());
        }
    }
}
