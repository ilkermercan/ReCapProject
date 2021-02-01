using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new CarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear + "  " + car.BrandName + "  " + car.Description + " = " + car.DailyPrice + " TL");
            }
        }
    }
}
