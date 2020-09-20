using System;

namespace ClassesAbstratas.Entities
{
    public abstract class Shape{
        public String Color { get; set; }

        public Shape(){}
        public Shape(string color){
            this.Color = color;
        }
        public abstract double Area();
    }
}