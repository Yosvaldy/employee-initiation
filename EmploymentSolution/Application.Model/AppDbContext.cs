namespace Application.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Entities;

    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=AppModel")
        {
        }

        public virtual DbSet<AccessLevel> AccessLevels { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyAccessLevel> CompanyAccessLevels { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employment> Employments { get; set; }
        public virtual DbSet<EmploymentAdditionalService> EmploymentAdditionalServices { get; set; }
        public virtual DbSet<EmploymentCompanyAccessLevel> EmploymentCompanyAccessLevels { get; set; }
        public virtual DbSet<EmploymentOtherPosition> EmploymentOtherPositions { get; set; }
        public virtual DbSet<EmploymentPosition> EmploymentPositions { get; set; }
        public virtual DbSet<EmploymentServiceEquipment> EmploymentServiceEquipments { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<ServiceEquipment> ServiceEquipments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessLevel>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AccessLevel>()
                .HasMany(e => e.CompanyAccessLevels)
                .WithRequired(e => e.AccessLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyAccessLevels)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyAccessLevel>()
                .HasMany(e => e.EmploymentCompanyAccessLevels)
                .WithRequired(e => e.CompanyAccessLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employments)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employment>()
                .Property(e => e.ManagerEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Employment>()
                .HasMany(e => e.EmploymentAdditionalServices)
                .WithRequired(e => e.Employment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employment>()
                .HasMany(e => e.EmploymentCompanyAccessLevels)
                .WithRequired(e => e.Employment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employment>()
                .HasMany(e => e.EmploymentOtherPositions)
                .WithRequired(e => e.Employment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employment>()
                .HasMany(e => e.EmploymentPositions)
                .WithRequired(e => e.Employment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employment>()
                .HasMany(e => e.EmploymentServiceEquipments)
                .WithRequired(e => e.Employment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmploymentAdditionalService>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EmploymentOtherPosition>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Position>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.EmploymentPositions)
                .WithRequired(e => e.Position)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceEquipment>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceEquipment>()
                .HasMany(e => e.EmploymentServiceEquipments)
                .WithRequired(e => e.ServiceEquipment)
                .WillCascadeOnDelete(false);
        }
    }
}
