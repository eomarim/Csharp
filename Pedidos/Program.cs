using System;
using Pedidos.Entities;
using Pedidos.Entities.Enums;
using System.Collections.Generic;

namespace Pedidos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var product = new Product("Monitor", 340.20);
            var product2 = new Product("Macbook", 7500.00);

            var orderItems = new List<OrderItem>();

                var orderItem1 = new OrderItem(10, product);
                var orderItem2 = new OrderItem(2, product2);

            orderItems.Add(orderItem1);
            orderItems.Add(orderItem2);

            var client = new Client("Eduardo", "e.oliveiramarim@gmail.com", DateTime.Parse( "1985-11-28 10:30"));

            var order = new Order(DateTime.Now, OrderStatus.PROCESSING, client, orderItems);

            System.Console.WriteLine(order);

            System.Console.WriteLine($"Total Pedido: {order.Total()}");

             order.RemoveItem(orderItem1);

            System.Console.WriteLine(order);
            System.Console.WriteLine($"Total Pedido: {order.Total()}");
           
            var orderItem3 = new OrderItem(12, new Product("Headphone", 2000.00));

            order.AddItem(orderItem3);
            
            System.Console.WriteLine(order);
            System.Console.WriteLine($"Total Pedido: {order.Total()}");
        }
    }
}
