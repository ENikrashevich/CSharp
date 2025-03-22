using classwork_15._03._2025.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork_15._03._2025.Factory
{
    public class FacilityTurkey : Facility
    {
        protected override ICar GetCar()
        {
            return new Golf(new CarPartsFactoryChina());
        }
    }
}
