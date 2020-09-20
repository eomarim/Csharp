using System;

namespace ClassesAbstratas.Entities
{
    public class Circle : Shape{

        public Circle(string color):base(color){}
        public override double Area()
        {
            return 0.02;
        }
    }
}