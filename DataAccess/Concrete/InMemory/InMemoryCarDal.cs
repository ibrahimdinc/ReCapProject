using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{CarId=1,BrandId=3,ColorId=1,DailyPrice=150,Description="Otoban faresi mavi Fiat Tipo 1994"},
                new Car{CarId=2,BrandId=3,ColorId=2,DailyPrice=300,Description="Enişteli, aile boyluk gri Doblo"},
                new Car{CarId=3,BrandId=8,ColorId=2,DailyPrice=500,Description="Gri Renault Clio"},
                new Car{CarId=4,BrandId=5,ColorId=5,DailyPrice=350,Description="Pembe Ford Fiesta"},
                new Car{CarId=5,BrandId=5,ColorId=6,DailyPrice=350,Description="Lacivert Ford Focus"}
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.Description+" sisteme eklendi.");
        }

        public void Delete(Car car)
        {
            Car thisCar = _cars.Find(c => c.CarId == car.CarId);
            _cars.Remove(thisCar);
            Console.WriteLine(thisCar.Description+" sistemden silindi.");
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }



        public Car GetByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public Car GetByFilter(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int CarId)
        {
            Car thisCar = _cars.Find(c => c.CarId == CarId);
            return thisCar;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car thisCar = _cars.Find(c => c.CarId == car.CarId);
            car.BrandId = thisCar.BrandId;
            car.ColorId = thisCar.ColorId;
            car.ModelYear = thisCar.ModelYear;
            car.Description = thisCar.Description;
            car.DailyPrice = thisCar.DailyPrice;
            Console.WriteLine(thisCar.CarId  + " numaralı araç bilgileri güncellendi.");
        }
    }
}
