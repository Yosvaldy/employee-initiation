using Application.DAL.Abstract.Interfaces;
using Application.Model.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace Application.DAL.Concrete.Repositories
{
    public class EmploymentRepository : Repository<Employment>, IEmploymentRepository
    {
        public EmploymentRepository(DbContext db) : base(db)
        {
        }

        public override IQueryable<Employment> GetAll()
        {
            return base.GetAll().Include(e => e.Company)
                                .Include(e => e.Position)
                                .Include(e => e.Equipments.Select(eq => eq.Equipment))
                                .Include(e => e.Accesses.Select(a => a.Access));
        }

        public override Employment GetById<T>(T id)
        {
            int emp = Convert.ToInt32(id);
            return GetById(e => e.Id == emp);
        }

        public override Employment Update(Employment entity)
        {
            UpdateAccess(entity);
            UpdateEquipment(entity);
            base.Update(entity);
            GetDbEntry(entity).Property(e => e.CreatedDate).IsModified = false;
            return entity;
        }
        
        public void UpdateAccess(Employment emp)
        {
            var accessDbSet = dbContext.Set<EmploymentAccess>();
            var toDelete = accessDbSet.Where(a => a.EmploymentId == emp.Id);
            accessDbSet.RemoveRange(toDelete);
            accessDbSet.AddRange(emp.Accesses);
        }

        public void UpdateEquipment(Employment emp)
        {
            var equipDbSet = dbContext.Set<EmploymentEquipment>();
            var toDelete = equipDbSet.Where(a => a.EmploymentId == emp.Id);
            equipDbSet.RemoveRange(toDelete);
            equipDbSet.AddRange(emp.Equipments);
        }
    }
}
