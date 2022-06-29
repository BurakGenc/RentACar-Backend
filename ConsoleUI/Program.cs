using Business.Concrete;
using DataAccess.Abstract;
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
             CarTest();
           

      

            
          //  EfColorDal efColorDal = new EfColorDal();
            /* efColorDal.Add(color);
             efColorDal.Add(color2);
            */

/*
            foreach (var c in efColorDal.GetAll())
            {
                Console.WriteLine(c.Name);
            }
           
            */

           /* EfBrandDal brandDal = new EfBrandDal(); 
            brandDal.Add(brand);
            brandDal.Add(brand2);*/
          

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

        private static void CarTest()
        {
            CarManager carMananger = new CarManager(new EfCarDal());



            var result = carMananger.GetAll();
            if (result.IsSuccess == true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.Name);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
