using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class CarDal:ICarDal
    {
        List<Car> _cars;
        public CarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1, BrandId = 1, BrandName= "Porsche 718 Catman T", ColorId= 2, DailyPrice=10000000, Description= "Tek kapılı spor araç.", ModelYear=2020  },
                new Car {Id = 2, BrandId = 2, BrandName= "Volkswagen 1303 VW", ColorId= 1, DailyPrice=60000, Description= "Klasik araç.", ModelYear=1973  },
                new Car {Id = 3, BrandId = 3, BrandName= "Cadillac Escalade", ColorId= 6, DailyPrice=25000000, Description= " Yüksek lüks sınıf bir SUV araç", ModelYear=2015  },
                new Car {Id = 4, BrandId = 4, BrandName= "Ford Mustang", ColorId= 8, DailyPrice=900000, Description= "Tek kapılı spor araç.", ModelYear=2017  },
                new Car {Id = 5, BrandId = 5, BrandName= "Mercedes W114 280", ColorId= 4, DailyPrice=275000, Description= "Klasik araç.", ModelYear=1968  }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;

        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.CarId = car.CarId;
        }


    }
}
