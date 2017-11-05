using Application.DAL.Abstract.Interfaces;
using Application.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
