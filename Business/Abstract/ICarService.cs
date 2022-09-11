using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCarsbyColor(string color);
        bool UpdateCarbyCarId(int carId);
        bool DeleteCarbyCarId(int carId);
    }
}
