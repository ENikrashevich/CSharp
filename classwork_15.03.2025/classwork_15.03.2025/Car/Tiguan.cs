using classwork_15._03._2025.Factory;
using classwork_15._03._2025.Parts;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork_15._03._2025.Car
{
    public class Tiguan : ICar
    {
        private string _name;
        private string _body;
        private IEngine _engine;
        private IWheels _wheels;
        private ICarPartsFactory _partsFactory;

        public Tiguan(ICarPartsFactory partsFactory)
        {
            _name = "Tiguan";
            _body = "Crossover";
            _partsFactory = partsFactory;
        }

        public void AssemblyBody()
        {
            Console.WriteLine("Установка кузова {0}", _body);
        }

        public void AssemblyEngine()
        {
            _engine = _partsFactory.GetEngine();
        }

        public void AssemblyWheels()
        {
            _wheels = _partsFactory.GetWheels();
        }

        public string GetName()
        {
            return _name;
        }

        public string GetBody()
        { 
            return _body; 
        }
    }
}
