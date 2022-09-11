using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarService : ICarService
    {
        public bool DeleteCarbyCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsbyColor(string color)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCarbyCarId(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
