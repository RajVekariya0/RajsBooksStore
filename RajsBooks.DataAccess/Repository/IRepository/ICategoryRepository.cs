using RajsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RajsBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
