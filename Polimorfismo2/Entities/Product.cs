using System;

namespace Polimorfismo2.Entities
{
    public class Product{
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(){}
        public Product(string name, double price){
            this.Name = name;
            this.Price = price;
        }
        public virtual string PriceTag(){
            
            return $"Name:{this.Name}, Price:{this.Price.ToString("F2")}";
        }


    }
}