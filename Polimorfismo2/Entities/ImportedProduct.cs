using System;

namespace Polimorfismo2.Entities
{
    public class ImportedProduct : Product{
        
        public double CustomFee { get; set; }

        public ImportedProduct(){}

        public ImportedProduct(string name, double price, double customFee)
            : base(name, price){
                this.CustomFee = customFee;
            }

        public sealed override string PriceTag()
        {
            return $"{base.PriceTag()}, Custom Fee:{this.CustomFee.ToString("F2")}" ;
        }

        public double TotalPrice()
        {
            return base.Price + CustomFee;
        }
    }
}