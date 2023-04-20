using RajsBooks.DataAccess.Repository.IRepository;
using RajsBooksStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RajsBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }

    }
}
