using Application.DAL.Abstract.Interfaces;
using Application.Model.Entities;
using System.Data.Entity;
using System.Linq;

namespace Application.DAL.Concrete.Repositories
{
    public class EquipmentRepository : Repository<Equipment>, IEquipmentRepository
    {
        public EquipmentRepository(DbContext db) : base(db)
        {
        }

        public override IQueryable<Equipment> GetAll()
        {
            return base.GetAll();
        }
    }
}
