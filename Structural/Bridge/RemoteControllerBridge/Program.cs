// See https://aka.ms/new-console-template for more information
using RemoteControllerBridge.Models.Devices;
using RemoteControllerBridge.Models.Remotes;
using Shared.Services;

Console.WriteLine("Hello, Bridge Pattern!");
Logger.NextLine();

var smartRemote = new SmartRemote(device : new Radio());

CreateTitle("Mute : (before turn on)");
smartRemote.Mute();

CreateTitle("Turn the device on");
smartRemote.On();

CreateTitle("Set Channel to 10");
smartRemote.SetChannel(10);

CreateTitle("Increase the channel");
smartRemote.IncreaseChannel();
Console.WriteLine(smartRemote.GetCurrentChannel());

CreateTitle("Set volume to 150");
smartRemote.SetVolume(150);

CreateTitle("Decrease the Volume");
smartRemote.DecreaseVolume();
Console.WriteLine(smartRemote.GetCurrentVolume());

CreateTitle("Turn the device off");
smartRemote.Off();

static void CreateTitle(string message) {
    Console.WriteLine("================================");
    Console.WriteLine("Command :"   + message  + ":");
}
