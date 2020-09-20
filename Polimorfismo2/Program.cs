using System;
using Polimorfismo2.Entities;

namespace Polimorfismo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pro = new ImportedProduct("Monitor", 1000.00, 150.00);

            Product pro2 = new UsedProduct("Mouse", 100.00, DateTime.Parse("2019-10-10"));

            System.Console.WriteLine(pro.PriceTag());

            System.Console.WriteLine(pro2.PriceTag());

            //ImportedProduct impo = (ImportedProduct) pro; //Duas formas de fazer um downcasting
            ImportedProduct impo = pro as ImportedProduct; //Outra forma de fazer o downcasting

            System.Console.WriteLine(impo.TotalPrice());

            
        }
    }
}
