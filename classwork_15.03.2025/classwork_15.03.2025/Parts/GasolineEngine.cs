using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace classwork_15._03._2025.Parts
{
    public class GasolineEngine : IEngine
    {
        public GasolineEngine() 
        {
            Console.WriteLine("Установка бензинового двигателя");
        }
    }
}
