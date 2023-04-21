//using RajsBooks.DataAccess.Data;
using RajsBooks.DataAccess.Repository.IRepository;
using RajsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using RajsBooksStore.DataAccess.Data;
using RajsBooks.Models.ViewModels;

namespace RajsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;
            }
        }
    }
}
