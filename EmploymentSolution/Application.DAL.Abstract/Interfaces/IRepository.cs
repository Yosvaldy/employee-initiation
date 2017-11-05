using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.DAL.Abstract.Interfaces
{
    public interface IRepository<Model> where Model : class
    {
        IQueryable<Model> GetAll();
        IQueryable<Model> GetAll(Expression<Func<Model, bool>> predicate);
        Model GetById<T>(T id);
        Model GetById(Expression<Func<Model, bool>> IDPredicate);
        Model Create(Model entity);
        Model Delete(int id);
        Model Update(Model entity);
    }
}
