using RemoteControllerBridge.Abstractions;
using Shared.Services;

namespace RemoteControllerBridge.Models.Devices;
internal class TV : IDevice {
    private bool _isOn = false;
    public int Channel { get; set; } = 1;
    public int Volume { get; set; } = 0;

    public bool IsOn() => _isOn;

    public void Off() {
        _isOn = false;
        Logger.Log("TV : Off");
    }

    public void On() {
        _isOn = true;
        Logger.Log("TV : On");
    }

    public void SetChannel(int channelNumber) {
        Logger.Log($"TV : The channel number is {channelNumber}.");
    }

    public void SetVolume(int volumeNumber) {
        Logger.Log($"TV : The volume number is {volumeNumber}.");
    }
}