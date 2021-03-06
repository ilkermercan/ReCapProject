﻿using Core.DataAccess.IEntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (CarsDbContext context = new CarsDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto { CarId = c.CarId, BrandName = b.BrandName, ColorId = co.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
