﻿using AdvanceAPI.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAuthDAL AuthDAL { get; }
        void Commit();
        void BeginTransaction();
    }
}
