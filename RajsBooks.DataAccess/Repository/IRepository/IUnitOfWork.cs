using RajsBooks.DataAccess.Repository.IRepository;
using RajsBooksStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RajsBooks.DataAccess.Repository.IRepository
{
    public interface UnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IPS_Call SP_Call { get; }

    }
}
