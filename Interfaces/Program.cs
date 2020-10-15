using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var device = new DeviceService(new Celular());
            device.Processa();
         
        }
    }
}
