using patternComand.Devices;
using patternComand.Commands;
using patternComand;

var music = new YandexMusic();
var tv = new SamsungTV();

var cmdTV = new CommandSamsungTVTurnOn(tv);
var cmdMusicON = new CommandYandexMusicTurnOn(music);
var cmdMusicSkip = new CommandYandexMusicSkip(music);

var remote = new RemoteControl();
remote.SetCommandToButton(1, cmdMusicSkip);
remote.SetCommandToButton(2, cmdMusicON);
remote.SetCommandToButton(3, cmdTV);

Console.WriteLine(remote.ToString());
var idString = Console.ReadLine();

while (idString != null && idString != "")
{
    remote.PushButton(int.Parse(idString));
    Console.WriteLine(remote.ToString());
    idString = Console.ReadLine();
}