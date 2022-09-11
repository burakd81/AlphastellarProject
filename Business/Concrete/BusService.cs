using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BusService : IBusService
    {
        public List<Bus> GetCarsbyColor(string color)
        {
            throw new NotImplementedException();
        }
    }
}
