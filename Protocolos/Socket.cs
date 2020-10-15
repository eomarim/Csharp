using System;

namespace Protocolos
{
    public class Socket
    {
        static void Main(string[] args)
        {
            args = new string[]{ "pureTCP"};

            IProtocol protocol = new Heeap();

            if(args[0] == "pureTCP"){
                protocol = new PureTcp();
            }
        
            var commu = new Communication(protocol);
            commu.ProcessProtocol();
        }
    }
}
