using Application.DAL.Abstract.Interfaces;
using Application.Model.Entities;
using System.Data.Entity;
using System.Linq;

namespace Application.DAL.Concrete.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(DbContext db) : base(db)
        {
        }

        public override IQueryable<Company> GetAll()
        {
            return base.GetAll();
        }
    }
}
