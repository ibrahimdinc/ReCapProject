using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IServiceRepository<T>where T:IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T GetCarsByBrandId(int Id);
        T GetCarsByColorId(int Id);

    }
}
