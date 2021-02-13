using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
//    public class CarDal:ICarDal
//    {
//        List<Car> _cars;
//        public CarDal()
//        {
//            _cars = new List<Car>
//            {
//                new Car {CarId = 1, BrandId = 1, BrandName= "Porsche 718 Catman T", ColorId= 2, DailyPrice=10000000, Description= "Tek kapılı spor araç.", ModelYear=2020  },
//                new Car {CarId = 2, BrandId = 2, BrandName= "Volkswagen 1303 VW", ColorId= 1, DailyPrice=60000, Description= "Klasik araç.", ModelYear=1973  },
//                new Car {CarId = 3, BrandId = 3, BrandName= "Cadillac Escalade", ColorId= 6, DailyPrice=25000000, Description= " Yüksek lüks sınıf bir SUV araç", ModelYear=2015  },
//                new Car {CarId = 4, BrandId = 4, BrandName= "Ford Mustang", ColorId= 8, DailyPrice=900000, Description= "Tek kapılı spor araç.", ModelYear=2017  },
//                new Car {CarId = 5, BrandId = 5, BrandName= "Mercedes W114 280", ColorId= 4, DailyPrice=275000, Description= "Klasik araç.", ModelYear=1968  }
//            };
//        }
//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
//            _cars.Remove(carToDelete);
//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;

//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAllByCars(int carsId)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetById(int Id)
//        {
//            return _cars.Where(c => c.CarId == Id).ToList();
//        }

//        public List<CarDetailDto> GetCarDetailDtos()
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Description = car.Description;
//            carToUpdate.CarId = car.CarId;
//        }


//    }
}
