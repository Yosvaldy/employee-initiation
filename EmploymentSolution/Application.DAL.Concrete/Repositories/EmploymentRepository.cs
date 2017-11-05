using Application.DAL.Abstract.Interfaces;
using Application.DAL.Concrete.Repositories;
using Application.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DAL.Concrete.Repositories
{
    public class EmploymentRepository : Repository<Employment>, IEmploymentRepository
    {
        public EmploymentRepository(DbContext db) : base(db)
        {
        }

        public override IQueryable<Employment> GetAll()
        {
            return base.GetAll();
        }
    }
}
