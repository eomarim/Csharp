using System;
using Polimorfismo.Entities;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee("Eduardo Marim", 168, 80.00);
            Employee ou = new OutsourcedEmployee("Renata Sperandio", 168, 80.00, 20);
            
            System.Console.WriteLine(em);
            System.Console.WriteLine($"Payment {em.Payment().ToString("F2")}");

            System.Console.WriteLine(ou);
            System.Console.WriteLine($"Payment {ou.Payment().ToString("F2")}");
        }
    }
}
