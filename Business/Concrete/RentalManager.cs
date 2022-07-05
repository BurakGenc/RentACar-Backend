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

            if (GetLastRental(rental.CarId).ReturnDate.Year ==1 )
            {
                return new ErrorResult("Araç Teslim edilmemiş kiralanamaz");
            }
            _rentaldal.Add(rental);
            return new SuccessResult();

        }

        public Rental GetLastRental(int id)
        {
            return _rentaldal.GetLastRental(p=>p.CarId == id);
        }

        public IResult Update(Rental rental)
        {
            _rentaldal.Update(rental);
            return new SuccessResult(); 
        }
    }
}
