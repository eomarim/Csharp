using System;

namespace Interfaces
{
    public class DeviceService
    {
        private IDevice _iDevice { get; set; }
        public DeviceService(IDevice iDevice){
            this._iDevice = iDevice;
        }

        public void Processa(){
            this._iDevice.Ligar();
        }

    }
}