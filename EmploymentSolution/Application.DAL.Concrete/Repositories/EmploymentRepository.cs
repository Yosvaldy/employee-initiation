using Application.DAL.Abstract.Interfaces;
using Application.Model.Entities;
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
            return base.GetAll().Include(e => e.Company).Include(e => e.Position).Include(e => e.ServiceEquipments).Include(e => e.AccessLevels);
        }
    }
}
