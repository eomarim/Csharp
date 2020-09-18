using System;

namespace Pedidos.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

  
        public OrderItem(int quantity, Product product){
            this.Quantity = quantity;
            this.Price = product.Price;
            this.Product = product;
        }
        public double SubTotal(){
            return this.Quantity * this.Price;
        }
    }
}