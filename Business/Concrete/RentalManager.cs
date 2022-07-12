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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentaldal;

        public RentalManager(IRentalDal rentaldal)
        {
            _rentaldal = rentaldal;
        }

        public IResult Add(Rental rental)
           
        {

            if (GetLastRental(rental.CarId).Data.ReturnDate.Year ==1 )
            {
                return new ErrorResult("Araç Teslim edilmemiş kiralanamaz");
            }
            _rentaldal.Add(rental);
            return new SuccessResult();

        }

        public IResult Delete(Rental rental)
        {
            _rentaldal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentaldal.GetAll()," Kiralama listesi");
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
           return new SuccessDataResult<Rental>(_rentaldal.Get(p=>p.Id == rentalId));
        }

        public IDataResult<Rental> GetLastRental(int id)
        {
            return  new SuccessDataResult<Rental>(_rentaldal.GetLastRental(p=>p.CarId == id));
        }

        public IResult Update(Rental rental)
        {
            _rentaldal.Update(rental);
            return new SuccessResult(); 
        }
    }
}
