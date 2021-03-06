﻿using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var result = new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CarId == rental.CarId)).Data;
            if (result != null)
            {
                if (result.ReturnDate == null || result.ReturnDate > DateTime.Now)
                {
                    return new ErrorResult(Messages.CantRent);
                }
            }
            else
            {
                _rentalDal.Add(rental);
            }

            return new SuccessResult(Messages.RentAdded);
        }



        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
