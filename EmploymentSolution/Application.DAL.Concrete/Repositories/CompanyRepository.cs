using Application.DAL.Abstract.Interfaces;
using Application.Model.Entities;
using System;
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
            return base.GetAll().Include(c => c.Accesses.Select(a => a.Access));
        }

        public override Company GetById<T>(T id)
        {
            int com = Convert.ToInt32(id);
            return GetById(e => e.Id == com);
        }
    }
}
