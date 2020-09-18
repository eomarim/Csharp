using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System;
using Pedidos.Entities.Enums;

namespace Pedidos.Entities
{
    public class Order
    {
        public DateTime Momment { get; set; }

        public OrderStatus Status { get; set; }

        public Client Client { get; set; }

        List<OrderItem> items {get; set;}

        public Order(){}

        public Order(DateTime momment, OrderStatus status, Client client, List<OrderItem> items){
            this.Momment = momment;
            this.Status = status;
            this.Client = client;
            this.items = items;
        }

        public void AddItem(OrderItem item){
            this.items.Add(item);
        }

        public void RemoveItem(OrderItem item){
            this.items.Remove(item);
        }

        public double Total(){

            double total = 0.00;

            foreach (OrderItem item in items)
            {
                total+= item.SubTotal();    
            }

            return total;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("---------INICIO PROCESSO-----------");
            sb.Append("Momento do Pedido:");
            sb.AppendLine(this.Momment.ToString());
            sb.AppendLine("----------------");
            sb.Append("Status do Pedido:");
            sb.AppendLine(this.Status.ToString());
            sb.AppendLine(this.Client.ToString());
            sb.AppendLine("----------------");

            foreach (OrderItem item in this.items)
            {
                
                sb.Append(item.Product.ToString());
                sb.Append("Quantidade:");
                sb.AppendLine(item.Quantity.ToString());
                sb.Append("SubTotal:");
                sb.AppendLine(item.SubTotal().ToString());
                sb.AppendLine("--------------");

            }
        
            return sb.ToString();
        }


    }
}