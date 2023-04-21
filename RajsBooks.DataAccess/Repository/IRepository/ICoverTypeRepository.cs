using System;
using System.Collections.Generic;
using System.Text;
using RajsBooks.Models;
using System.Linq;
using RajsBooks.Models.ViewModels;

namespace RajsBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
