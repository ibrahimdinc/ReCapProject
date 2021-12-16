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
    public class EfBrandDal:IBrandDal
    {
        public void Add(Brand entity)
        {

            using (ReCapContext context = new ReCapContext())
            {
                var newEntity = context.Entry(entity);
                newEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var newEntity = context.Entry(entity);
                newEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(Brand entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var newEntity = context.Entry(entity);
                newEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
            }
        }

<<<<<<< HEAD
        public Brand GetByFilter(int id)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Brand>().SingleOrDefault(p=>p.Id==id);
=======
        public Brand GetByFilter(Expression<Func<Brand, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
>>>>>>> 20102bcd03f35ef74cdefb3dd9f229df807c072b
            }
        }
    }
}
