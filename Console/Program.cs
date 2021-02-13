using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserAddTest();
            RentalTest();
            //CarDeletedTest();
            //BrandIdTest();
            //ColorTest();
            //BrandTest();
            //CarAddTest();
            //CarDetailTest();

        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                foreach (var car in result.Data)
                {
                    Console.WriteLine($"Brand Name:{car.BrandName}\nColor Name:{car.ColorName}\nDaily Price:{car.DailyPrice}");
                    Console.WriteLine("---------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                BrandName = "AUDI",
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 300000,
                ModelYear = 2015
            });
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine($"Car Name:{car.BrandName}\nDaily Price:{car.DailyPrice}");
                Console.WriteLine("---------------------------------------------------------");
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName + "/" + brand.BrandId);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName + "/" + color.ColorId);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.GetCarsByBrandId(12).Data.BrandName);
        }

        private static void CarDeletedTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { BrandName = "Tesla", BrandId = 2, ColorId = 3, DailyPrice = 2000000, ModelYear = 2020, Description = "Kiralık Tesla", CarId = 2 });
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental
            {
                CarId = 5,
                RentDate = DateTime.Now,
                CustomerId = 3,
                ReturnDate = DateTime.Now.AddDays(2),
                RentalId = 1
            };

            if (rentalManager.Add(rental).Success == true)
            {
                rentalManager.Add(rental);
            }
            else
            {
                Console.WriteLine(rentalManager.Add(rental).Message);
            }
        }

        private static void UserAddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User { FirstName = "Merve", LastName = "MERCAN", Email = "mervemercan@outlook.com", UserPassword = "12t312ue" };

            if (userManager.Add(user).Success == true)
            {
                userManager.Add(user);

            }
            else
            {
                Console.WriteLine(userManager.Add(user).Message);
            }
        }
    }
}
