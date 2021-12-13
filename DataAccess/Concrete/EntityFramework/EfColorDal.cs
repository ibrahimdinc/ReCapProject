﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal:IColorDal
    {
        public void Add(Color entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var newEntity = context.Entry(entity);
                newEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var newEntity = context.Entry(entity);
                newEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(Color entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var newEntity = context.Entry(entity);
                newEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public Color GetByFilter(int id)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Color>().SingleOrDefault(p => p.Id == id);
            }
        }
    }
}