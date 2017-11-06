using Application.DAL.Abstract.Interfaces;
using Application.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Application.DAL.Concrete.Repositories
{
    public class PositionRepository : Repository<Position>, IPositionRepository
    {
        public PositionRepository(DbContext db) : base(db)
        {
        }

        public override IQueryable<Position> GetAll()
        {
            return base.GetAll();
        }
    }
}
