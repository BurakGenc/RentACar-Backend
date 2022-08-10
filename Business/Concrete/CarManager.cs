using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {

            ValidationTool.Validate(new CarValidator(), car);
           
            _carDal.Add(car);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 6)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }


            return new SuccessDataResult<List<Car>>( _carDal.GetAll(),Messages.ProductListed);
        }

        public IDataResult<Car> GetById(int carId)
        {
           return new SuccessDataResult<Car>(_carDal.Get(p=>p.Id == carId));

        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.ProductListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
          return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.BrandId==id), Messages.ProductListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id), Messages.ProductListed);
        }

        public IResult Update(Car car)
        {
             _carDal.Update(car);
            return new SuccessResult();
        }

        

    }
}
