using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>where T:IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
<<<<<<< HEAD
        T GetByFilter(int id);
=======
        T GetByFilter(Expression<Func<T, bool>> filter);
>>>>>>> 20102bcd03f35ef74cdefb3dd9f229df807c072b
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
