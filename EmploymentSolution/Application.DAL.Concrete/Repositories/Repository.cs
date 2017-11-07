using Application.DAL.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.DAL.Concrete.Repositories
{
    public class Repository<Model> : IRepository<Model> where Model : class
    {
        public DbContext dbContext { get; set; }
        protected DbSet<Model> dbSet;

        public Repository(DbContext db)
        {
            this.dbContext = db;
            dbContext.Configuration.LazyLoadingEnabled = false;
            this.dbSet = this.dbContext.Set<Model>();
        }

        public virtual IQueryable QueryableQuery
        {
            get
            {
                var QueryableQuery = this.dbSet.AsQueryable();
                return QueryableQuery;
            }
        }
        public virtual Model Create(Model entity)
        {
            this.dbSet.Add(entity);
            //this.dbContext.SaveChanges();
            return entity;
        }

        public virtual Model Delete(int id)
        {
            var dbEntry = this.GetById(id);
            if (dbEntry != null)
                this.dbSet.Remove(dbEntry);
            return dbEntry;
        }

        public virtual Model Update(Model entity)
        {
            var entry = this.GetDbEntry(entity);
            dbSet.Attach(entity);
            entry.State = EntityState.Modified;
            return entity;
        }

        public virtual Model GetById<T>(T id)
        {
            dbContext.Configuration.AutoDetectChangesEnabled = false;
            var entity = this.dbSet.Find(id);
            dbContext.Configuration.AutoDetectChangesEnabled = true;
            return entity;
        }

        public virtual Model GetById(Expression<Func<Model, bool>> IDPredicate)
        {
            return GetAll(IDPredicate).FirstOrDefault();
        }

        public DbEntityEntry<Model> GetDbEntry(Model m)
        {
            return dbContext.Entry(m);
        }

        public DbEntityEntry<Model> GetDbEntry<T>(T id)
        {
            var dbEntity = dbSet.Find(id);
            return this.dbContext.Entry(dbEntity);
        }

        public virtual IQueryable<Model> GetAll()
        {
            return QueryableQuery as IQueryable<Model>;
        }

        public virtual IQueryable<Model> GetAll(Expression<Func<Model, bool>> predicate)
        {
            var query = GetAll().Where(predicate);
            return query.AsQueryable();
        }
    }
}
