using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return _brandDal.GetAll();
        }

        public Brand GetCarsByBrandId(int Id)
        {
<<<<<<< HEAD
            return _brandDal.GetByFilter(Id);
=======
            return _brandDal.GetByFilter(p => p.Id == Id);
>>>>>>> 20102bcd03f35ef74cdefb3dd9f229df807c072b
        }

        public Brand GetCarsByColorId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
