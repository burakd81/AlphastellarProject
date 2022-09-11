using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarService : ICarService
    {
        private readonly ICarDal _carDal;

        public CarService(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public bool DeleteCarbyCarId(int carId)
        {
            var car = _carDal.Get(x => x.Id == carId && x.IsDeleted == false);
            car.IsDeleted = true;
            car.UpdatedDate = DateTime.Now;
            _carDal.Update(car);
            return true;
        }

        public List<Car> GetCarsbyColor(string color)
        {
            var cars = _carDal.GetList(x => x.Color.Contains(color)).ToList();
            return cars;
        }

        public bool OnOffHeadLights(int carId)
        {
            var car = _carDal.Get(x=>x.Id==carId && x.IsDeleted ==false);
            if (car.Headlights == true)
                car.Headlights = false;
            else
                car.Headlights = true;
            car.UpdatedDate = DateTime.Now;
            _carDal.Update(car);
            return true;
        }
    }
}
