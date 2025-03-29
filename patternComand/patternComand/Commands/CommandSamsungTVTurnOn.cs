using patternComand.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternComand.Commands
{
    public class CommandSamsungTVTurnOn : ICommand
    {
        private SamsungTV _samsungTV;

        public CommandSamsungTVTurnOn(SamsungTV samsungTV)
        {
            _samsungTV = samsungTV;
        }
        public void Execute()
        {
            _samsungTV.TurnOn();
        }

        public override string? ToString()
        {
            return "Включить|Выключить";
        }
    }
}
