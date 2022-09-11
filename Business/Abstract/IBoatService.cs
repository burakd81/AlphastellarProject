using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBoatService
    {
        List<Boat> GetCarsbyColor(string color);
    }
}
