using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand customer)
        {
            _brandDal.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Brand customer)
        {
            _brandDal.Delete(customer);

            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),"Markalar Listelendi");
        }

        public IDataResult<Brand> GetById(int brandId)
        {
           return new SuccessDataResult<Brand>(_brandDal.Get(p=>p.Id== brandId));
        }

        public IResult Update(Brand customer)
        {
            _brandDal.Update(customer);
            return new SuccessResult();
        }
    }
}
