using Application.DAL.Abstract.Interfaces;
using Application.Model.Entities;
using System.Data.Entity;
using System.Linq;

namespace Application.DAL.Concrete.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext db) : base(db)
        {
        }

        public override IQueryable<Employee> GetAll()
        {
            return base.GetAll();
        }
    }
}
