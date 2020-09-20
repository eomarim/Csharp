using System;

namespace Polimorfismo2.Entities
{
    public class UsedProduct : Product{
        
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct(){}

        public UsedProduct(string name, double price, DateTime manufacturedDate)
            :base(name, price){
                this.ManufacturedDate = manufacturedDate;
            }

        public override string PriceTag()
        {
            return $"{base.PriceTag()}, Manufactured Date:{this.ManufacturedDate.ToString()}";
        }
    }
}