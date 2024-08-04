using RemoteControllerBridge.Abstractions;
using Shared.Services;

namespace RemoteControllerBridge.Models.Devices;

internal class Radio : IDevice {
    private bool isOn = false;  
    public int Channel {  get; set; } = 1;

    public int Volume { get; set; } = 0;

    public bool IsOn() => isOn;

    public void Off() {
        isOn = false;   
        Logger.Log("Radio : Off");
    }

    public void On() {
        isOn = true;
        Logger.Log("Radio : On");
    }

    public void SetChannel(int channelNumber) {
        Logger.Log($"Radio : The channel number is {channelNumber}.");
        Channel = channelNumber;
    }

    public void SetVolume(int volumeNumber) {
        Logger.Log($"Radio : The volume number is {volumeNumber}.");
        Volume = volumeNumber;
    }
}
