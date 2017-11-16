using System.Data.Entity;

namespace Application.DAL.Concrete.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
        DbContext Context { get; set; }
    }

    public class UnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; set; }

        public UnitOfWork(DbContext db)
        {
            this.Context = db;
        }

        public void Commit()
        {
            this.Context.SaveChanges();
        }
    }
}
