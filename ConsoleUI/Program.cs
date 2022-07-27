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
            // CarTest();        

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
