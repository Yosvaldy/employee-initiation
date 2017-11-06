using Application.DAL.Abstract.Interfaces;
using Application.Model.Entities;
using System.Data.Entity;
using System.Linq;

namespace Application.DAL.Concrete.Repositories
{
    public class AccessLevelRepository : Repository<AccessLevel>, IAccessLevelRepository
    {
        public AccessLevelRepository(DbContext db) : base(db)
        {
        }

        public override IQueryable<AccessLevel> GetAll()
        {
            return base.GetAll();
        }
    }
}
