using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetCarsByBrandId(int brandId);
        IDataResult<Car> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
