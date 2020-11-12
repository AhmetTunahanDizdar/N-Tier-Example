﻿using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }

        ICategoryRepository Categories { get; }

        Task CommitAsync();//hafızada tutup sonra yansıtması için commit metonu yazdık.

        void Commit();

    }
}
