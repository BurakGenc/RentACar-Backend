using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentAcarContext>, IRentalDal
    {
        public Rental GetLastRental(Expression<Func<Rental, bool>> filter)
        {
            using (RentAcarContext context = new RentAcarContext())
            {
                return context.Set<Rental>().OrderBy(p=>p.Id).Last(filter);
            }
        }
    }
}
