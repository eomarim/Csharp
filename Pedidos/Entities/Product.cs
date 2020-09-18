using System.Text;
using System;

namespace Pedidos.Entities{
    public class Product{
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(){

        }
        public Product(string name, double Price){
            this.Name = name;
            this.Price = Price;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Name:");
            sb.AppendLine(this.Name);
            sb.Append("Price:");
            sb.AppendLine(this.Price.ToString());

            return sb.ToString();
        }
    }
}