using System;

namespace Polimorfismo.Entities
{
    public class OutsourcedEmployee : Employee{
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(){}

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            :base(name, hours, valuePerHour){
                this.AdditionalCharge = additionalCharge;
        }
        public sealed override double Payment()
        {
            return base.Payment() + this.AdditionalCharge;
        }

        public override string ToString()
        {
            return $"#####Outsourced Employee##### Name:{base.Name}, Hours:{base.Hours}, " +
                $"Value Per Hour:${base.ValuePerHour}, Adcional Charge:${this.AdditionalCharge}";
        }
    }
    
}