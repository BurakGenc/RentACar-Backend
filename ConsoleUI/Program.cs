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


            /* EfUserDal efUserDal = new EfUserDal();
             User user=new User { Id=1,Email="abcd@gmail.com",FirstName="abcd",LastName="aaaa",Password="12345"};
             User user1 = new User { Id = 2, Email = "xyz@gmail.com",FirstName = "xyz", LastName = "bbbb", Password = "12345a" };
             User user2 = new User { Id = 3, Email = "efgh@gmail.com", FirstName = "efgh", LastName = "cccc", Password = "12345b" };
             User user3 = new User { Id = 4, Email = "qwerty@gmail.com", FirstName = "qwerty", LastName = "dddd", Password = "12345c" };
             User user4 = new User { Id = 5, Email = "klmn@gmail.com", FirstName = "klmn", LastName = "eeee", Password = "12345d" };


             efUserDal.Add(user);
             efUserDal.Add(user1);
             efUserDal.Add(user2);
             efUserDal.Add(user3);
             efUserDal.Add(user4);
            */

            /* EfCustomerDal efCustomerDal = new EfCustomerDal();
             Customer customer = new Customer { Id=1,UserId=1,CompanyName="akbank"};
             Customer customer1 = new Customer { Id = 2, UserId = 2, CompanyName = "acer" };
             Customer customer2 = new Customer { Id = 3, UserId = 3, CompanyName = "zorlu" };
             Customer customer3= new Customer { Id = 4, UserId = 4, CompanyName = "sabanci" };
             Customer customer4 = new Customer { Id = 5, UserId = 5, CompanyName = "koc" };

             efCustomerDal.Add(customer);
             efCustomerDal.Add(customer1);
             efCustomerDal.Add(customer2);
             efCustomerDal.Add(customer3);
             efCustomerDal.Add(customer4);
            */


            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental = new Rental { Id = 9, CarId = 1, CustomerId = 2, RentDate = new DateTime(2022, 06, 27), ReturnDate = new DateTime(2022,09,09) };

            rentalManager.Update(rental);

            
           /* RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var a =rentalManager.GetLastRental(1);
            Console.WriteLine(a.ReturnDate);*/

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
