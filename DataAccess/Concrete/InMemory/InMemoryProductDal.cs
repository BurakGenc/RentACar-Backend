using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryProductDal()
        {
            _cars = new List<Car> {
              new Car{Id=1,BrandId=1,ColorId=4,DailyPrice=500000,ModelYear=500000,Description="müthiş bişi" },
              new Car{Id=2,BrandId=1,ColorId=5,DailyPrice=50000,ModelYear=500000,Description="0 ayarında" },
              new Car{Id=3,BrandId=2,ColorId=3,DailyPrice=500000,ModelYear=500000,Description="sigara bile içilmedi" },
              new Car{Id=4,BrandId=3,ColorId=1,DailyPrice=500000,ModelYear=500000,Description="yemede yanında yat" },


            };

        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {/*
            Car carToDelete=null;
            foreach (Car p in _cars)
            {
                if (car.Id == p.Id)
                {
                    carToDelete=p;
                }
            }
            _cars.Remove(carToDelete);*/

            Car result=_cars.SingleOrDefault(p=>p.Id==car.Id);
            _cars.Remove(result);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            Car result = _cars.SingleOrDefault(p => p.Id == id);

            return result;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car result = _cars.SingleOrDefault(p => p.Id == car.Id);
            result.Description = car.Description;
            result.ModelYear = car.ModelYear;
            result.ColorId = car.ColorId;
            result.DailyPrice = car.DailyPrice;
            result.BrandId = car.BrandId;

        }
    }
}
