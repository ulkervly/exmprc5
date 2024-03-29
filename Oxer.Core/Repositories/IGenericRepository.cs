﻿using Microsoft.EntityFrameworkCore;
using Oxer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Oxer.Core.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity, new()
    {
        DbSet<T> Table {  get; }
        Task CreateAsync(T entity);
        void Delete(T entity);
        Task<int> CommitAsync();
        IQueryable<T> GetAll(params string[] includes);
        IQueryable<T> GetAllWhere(Expression<Func<T,bool>>?expression=null,params string[] includes);
        Task<T> GetSingleAsync(Expression<Func<T,bool>>?expression=null,params string[] includes);
    }
}
