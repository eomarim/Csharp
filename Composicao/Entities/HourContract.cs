using System;

namespace Composicao.Entities{
    public class HourContract{
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        public double TotalValue(){
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return $"Date: {Date}, Value Per Hour: {ValuePerHour}, Hours: {Hours}";
        }
    }
}