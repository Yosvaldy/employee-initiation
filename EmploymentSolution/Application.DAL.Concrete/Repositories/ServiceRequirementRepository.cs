using Application.DAL.Abstract.Interfaces;
using Application.Model.Entities;
using System.Data.Entity;
using System.Linq;

namespace Application.DAL.Concrete.Repositories
{
    public class ServiceRequirementRepository : Repository<ServiceEquipment>, IServiceEquipmentRepository
    {
        public ServiceRequirementRepository(DbContext db) : base(db)
        {
        }

        public override IQueryable<ServiceEquipment> GetAll()
        {
            return base.GetAll();
        }
    }
}
