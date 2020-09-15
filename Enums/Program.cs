using System;
using Enums.Entities;
using Enums.Entities.Enums;

namespace Enums
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var order = new Order(){
               Id = 1,
               Momment = DateTime.UtcNow,
                Status = OrderStatus.PendingPayment
           };

           System.Console.WriteLine(order);

           //int numero =  (int) OrderStatus.Delivered; //Pase de um enum

           int numero = (int) Enum.Parse<OrderStatus>("Delivered"); //Outra forma de Parse
           System.Console.WriteLine(numero.ToString());

           OrderStatus os = Enum.Parse<OrderStatus>("Shipped"); 
           System.Console.WriteLine(os.ToString());

           

           


        }
    }
}
