using System;

namespace Interfaces
{
    public class Celular : IDevice
    {

         public void Ligar(){
             System.Console.WriteLine("Celular Ligado");
         }

         public void FazerLigacao(){
             System.Console.WriteLine("Ligando!!!");
         }
    }
}