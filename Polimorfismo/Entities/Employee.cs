using System;

namespace Polimorfismo.Entities
{
    public class Employee{
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee(){}

        public Employee(string name, int hours, double valuePerHour){
            this.Name = name;
            this.Hours = hours;
            this.ValuePerHour = valuePerHour;
        }

        public virtual double Payment(){
            return this.Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return $"####Employee#### Name:{this.Name}, Hours:{this.Hours}, Value Per Hour:${this.ValuePerHour.ToString("F2")}";
        }
    }
}