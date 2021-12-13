using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            if(entity.DailyPrice>0 && entity.Description.Length>2)
            {
                using (ReCapContext context = new ReCapContext())
                {
                    var newEntity = context.Entry(entity);
                    newEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
            }
            
        }

        public void Delete(Car entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var newEntity = context.Entry(entity);
                newEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(Car entity)
        {
            using (ReCapContext context= new ReCapContext())                
            {
                var newEntity = context.Entry(entity);
                newEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public Car GetByFilter(Expression<Func<Car, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        
    }
}
