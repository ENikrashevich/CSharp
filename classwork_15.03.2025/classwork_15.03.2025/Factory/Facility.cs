using classwork_15._03._2025.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork_15._03._2025.Factory
{
    public abstract class Facility
    {
        protected abstract ICar GetCar();

        public ICar BuildCar()
        {
            var car = GetCar();
            Console.WriteLine("Создание машины {0}", car.GetName());
            car.AssemblyBody();
            car.AssemblyEngine();
            car.AssemblyWheels();
            return car;
        }
    }
}
