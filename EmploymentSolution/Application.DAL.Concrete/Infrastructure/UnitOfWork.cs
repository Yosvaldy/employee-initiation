using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

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
