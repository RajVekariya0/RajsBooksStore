﻿using RajsBooksStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace RajsBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        ISP_Call SP_Call { get; }

        void Save(); 
      
    }
}
