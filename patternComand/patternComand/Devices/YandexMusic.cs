using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternComand.Devices
{
    public class YandexMusic
    {
        private DeviceState _state;
        public void TurnOn()
        {
            if (_state == DeviceState.OFF)
            {
                _state = DeviceState.ON;
                Console.WriteLine("Музыка Включена");
            }
            else
            {
                _state = DeviceState.OFF;
                Console.WriteLine("Музыка Выключена");
            }
        }
        public void SkipTrack()
        {
            if (_state == DeviceState.OFF)
            {
                _state = DeviceState.ON;
                Console.WriteLine("Музыка Включена");
            }
            Console.WriteLine("Следующий Трек");
        }
    }
}
