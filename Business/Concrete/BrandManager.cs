using Business.Abstract;
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
        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
