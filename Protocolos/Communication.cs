
namespace Protocolos
{
    public class Communication
    {
      private IProtocol _iProtocol;

      public Communication(IProtocol iProtocol){
          this._iProtocol = iProtocol;
      }

      public void ProcessProtocol(){
          _iProtocol.ProcessProtocol();
      }

    }
}