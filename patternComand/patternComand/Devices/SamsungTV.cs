using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternComand.Devices
{
    public class SamsungTV
    {
        private DeviceState _state;
        public void TurnOn()
        {
            if (_state == DeviceState.OFF)
            {
                _state = DeviceState.ON;
                Console.WriteLine("Телевизор Включена");
            }
            else
            {
                _state = DeviceState.OFF;
                Console.WriteLine("Телевизор Выключена");
            }
        }
    }
}
