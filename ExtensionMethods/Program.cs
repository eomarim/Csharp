using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2020, 10, 13, 10, 20, 10);
            System.Console.WriteLine(dt.ElapsedTime());

            string nome = "Eduardo Oliveira Marim";
            System.Console.WriteLine(nome.Cortar(10));

            System.Console.WriteLine("Eduardo .Oliveira, Marim".ContarPalavras());

            System.Console.WriteLine(25.Somar(9));
        }


    }

   
}
