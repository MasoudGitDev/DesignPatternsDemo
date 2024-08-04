using RemoteControllerBridge.Abstractions;
using Shared.Services;

namespace RemoteControllerBridge.Models.Remotes;
internal class SmartRemote(IDevice device) : IRemote {

    public int GetCurrentChannel() {
        if(device.IsOn()) {
            return device.Channel;
        }
        else {
            Logger.Log("At first , You must turn the device on.");
            return 0;
        }
    }

    public int GetCurrentVolume() {
        if(device.IsOn()) {
            return device.Volume;
        }
        else {
            Logger.Log("At first , You must turn the device on.");
            return 0;
        }
    }

    public void DecreaseChannel() {
        CheckState(() => {
            if(device.Channel <= 1) {
                device.Channel = 1;
            }
            else {
                device.Channel -= 1;
            }
        });
    }

    public void DecreaseVolume() {      
        CheckState(() => {
            if(device.Volume <= 0) {
                device.Volume = 0;
            }
            else {
                device.Volume -= 1;
            }
        });
    }

    public void IncreaseChannel() {  
        CheckState(() => {
            device.Channel += 1;
        });
    }

    public void IncreaseVolume() {    
        CheckState(() => {
            if(device.Channel <= 100) {
                device.Channel += 1;
            }
            else {
                device.Channel = 100;
            }
        });
    }

    public void Mute() {
        CheckState(() => {
            device.Volume = 0;
        });        
    }

    public void Off() {
        CheckState(() => device.Off());
    }

    public void On() {
        if(device.IsOn()) {
            Logger.Log("The device was on.");
        }
        else {
            device.On();
        }      
    }

    public void SetChannel(int channelNumber) {
        CheckState(() => device.SetChannel(channelNumber));
    }

    public void SetVolume(int volumeNumber) {
        CheckState(()=> {
            if(volumeNumber > 100) {               
                Logger.Log("The volume can not bigger than 100.");
                device.SetVolume(100);
            }
            else
            {
                device.SetVolume(volumeNumber);
            }    
        });       
    }

    private void CheckState(Action action) {
        if(device.IsOn()) {
            action();
        }
        else {
            Logger.Log("At first , You must turn the device on.");
        }
    }
}
