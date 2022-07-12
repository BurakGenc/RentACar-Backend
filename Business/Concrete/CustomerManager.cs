using Business.Abstract;
using Business.Constants;
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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerdal;

        public CustomerManager(ICustomerDal customerdal)
        {
            _customerdal = customerdal;
        }

        public IResult Add(Customer customer)
        {
            _customerdal.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
          _customerdal.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<List<Customer>> GetAll()
        {
           

            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll(),"Müşteri listelendi");
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerdal.Get(p => p.Id == customerId));
        }

        public IResult Update(Customer customer)
        {
           return new SuccessResult();
        }
    }
}
