using patternComand.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternComand.Commands
{
    public class CommandYandexMusicSkip : ICommand
    {
        private YandexMusic _music;
        public CommandYandexMusicSkip(YandexMusic music)
        {
            _music = music;
        }

        public void Execute()
        {
            _music.SkipTrack();
        }

        public override string? ToString()
        {
            return "Следующий Трек";
        }
    }
}
