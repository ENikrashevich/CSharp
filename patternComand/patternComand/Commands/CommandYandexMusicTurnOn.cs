using patternComand.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternComand.Commands
{
    public class CommandYandexMusicTurnOn : ICommand
    {
        private YandexMusic _music;
        public CommandYandexMusicTurnOn(YandexMusic music) 
        {
            _music = music;
        }

        public void Execute()
        {
            _music.TurnOn();
        }

        public override string? ToString()
        {
            return "Включить|Выключить музыку";
        }
    }
}
