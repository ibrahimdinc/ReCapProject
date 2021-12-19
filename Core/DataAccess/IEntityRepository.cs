﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T>where T:IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T GetByFilter(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
