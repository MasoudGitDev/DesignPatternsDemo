namespace RemoteControllerBridge.Abstractions;
internal interface IRemote {
    void Off();
    void On();
    void SetChannel(int channelNumber);
    void SetVolume(int volumeNumber);
    //=========== extra options
    void Mute();
    void IncreaseVolume();
    void DecreaseVolume();
    void IncreaseChannel();
    void DecreaseChannel();
}