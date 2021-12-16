using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _carDal.GetAll();
        }

        public Car GetCarsByBrandId(int Id)
        {
            return _carDal.GetByFilter(Id);
        }

        public Car GetCarsByColorId(int Id)
        {
            return _carDal.GetByFilter(Id);
        }
    }
}
