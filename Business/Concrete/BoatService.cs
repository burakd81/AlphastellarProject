using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BoatService : IBoatService
    {
        private readonly IBoatDal _boatDal;

        public BoatService(IBoatDal boatDal)
        {
            _boatDal = boatDal;
        }

        public List<Boat> GetCarsbyColor(string color)
        {
            var boats = _boatDal.GetList(x => x.Color.Contains(color)).ToList();
            return boats;
        }
    }
}
