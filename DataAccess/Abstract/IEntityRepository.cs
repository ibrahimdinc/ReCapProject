﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>where T:IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetByFilter(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}