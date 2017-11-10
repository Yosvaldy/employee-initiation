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
            return base.GetAll().Include(e => e.Company).Include(e => e.Position).Include(e => e.Equipments).Include(e => e.Accesses);
        }

        public override Employment GetById<T>(T id)
        {
            int empId = Convert.ToInt32(id);

            return GetAll().Include(e => e.Accesses).Include(e => e.Equipments).SingleOrDefault(e => e.Id == empId);
        }
    }
}
