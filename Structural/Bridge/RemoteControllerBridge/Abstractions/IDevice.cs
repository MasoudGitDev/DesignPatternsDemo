namespace RemoteControllerBridge.Abstractions;

internal interface IDevice {
    void Off();
    void On();
    void SetChannel(int channelNumber);
    void SetVolume(int volumeNumber);
    int Channel { get; set; }
    int Volume { get; set; }
    bool IsOn();
}
