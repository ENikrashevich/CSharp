using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace classwork_15._03._2025.Car
{
    public interface ICar
    {
        string GetName();
        void AssemblyBody();
        void AssemblyEngine();
        void AssemblyWheels();
    }
}
