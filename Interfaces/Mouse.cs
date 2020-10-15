using System;

namespace Interfaces
{
    public class Mouse : IDevice
    {
         public void Ligar(){
             System.Console.WriteLine("Mouse Ligado");
         }

         public void Clicar(){
             System.Console.WriteLine("Clicou!!!");
         }
    }
}
