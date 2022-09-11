using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BusService : IBusService
    {
        private readonly IBusDal _busDal;

        public BusService(IBusDal busDal)
        {
            _busDal = busDal;
        }
        public List<Bus> GetCarsbyColor(string color)
        {
            var buses = _busDal.GetList(x => x.Color.Contains(color)).ToList();
            return buses;
        }
    }
}
