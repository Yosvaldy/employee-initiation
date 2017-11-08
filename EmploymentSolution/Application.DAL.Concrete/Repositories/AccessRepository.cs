using Application.DAL.Abstract.Interfaces;
using Application.Model.Entities;
using System.Data.Entity;
using System.Linq;

namespace Application.DAL.Concrete.Repositories
{
    public class AccessRepository : Repository<Access>, IAccessRepository
    {
        public AccessRepository(DbContext db) : base(db)
        {
        }

        public override IQueryable<Access> GetAll()
        {
            return base.GetAll();
        }
    }
}
