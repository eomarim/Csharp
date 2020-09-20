using System;

namespace ClassesAbstratas.Entities
{
    public class Rectangle : Shape
    {
        public Rectangle(){}

        public Rectangle(string color):base(color){}

        public override double Area(){
            return 0.01;
        }
    }
}