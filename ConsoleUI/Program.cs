using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {



            CarManager carMananger = new CarManager(new EfCarDal());
            
            Car car2 = new Car { Id = 1,Name="A", BrandId = 1, ColorId = 4, DailyPrice = 0, ModelYear = 500000, Description = "müthiş bişi" };
            Car car3 = new Car { Id = 2, Name = "B" ,BrandId = 1, ColorId = 5, DailyPrice = 50000, ModelYear = 500000, Description = "0 ayarında" };
            Car car4 = new Car { Id = 3, Name = "C" ,BrandId = 2, ColorId = 3, DailyPrice = 500000, ModelYear = 500000, Description = "sigara bile içilmedi" };
            Car car5 = new Car { Id = 4, Name = "D", BrandId = 3, ColorId = 1, DailyPrice = 500000, ModelYear = 500000, Description = "yemede yanında yat" };

           
            
           

            foreach (var c in carMananger.GetCarsByBrandId(1))
            {
                Console.WriteLine(c.Id);
            }
           /* InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();*/

            
           /* Car car = new Car { Id = 4, BrandId = 3, ColorId = 1, DailyPrice = 32000, ModelYear = 2013, Description = "yemede yanında yat" };*/

            /*inMemoryProductDal.Delete(car);*/

            /*List<Car> cars = inMemoryProductDal.GetAll();
             foreach (var c in cars)
             {
                 Console.WriteLine(c.Description);  
             }*/


         /*   List<Car> x = carMananger.GetAll();
            foreach (Car c in x)
            {
                Console.WriteLine(c.Description);
            }
            
           

           
            */
          
        }
    }
}
