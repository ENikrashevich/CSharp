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
        private string _engine = "Diesel";
        private string _wheels = "\"17";

        public Tiguan()
        {
            _name = "Tiguan";
            _body = "Crossover";
        }

        public void AssemblyBody()
        {
            Console.WriteLine("Установка кузова {0}", _body);
        }

        public void AssemblyEngine()
        {
            Console.WriteLine("Установка двигателя {0}", _engine);
        }

        public void AssemblyWheels()
        {
            Console.WriteLine("Установка колес {0}", _wheels);
        }

        public string GetName()
        {
            return _name;
        }
    }
}
