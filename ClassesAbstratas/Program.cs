using System.Collections.Generic;
using System;
using ClassesAbstratas.Entities;
using Rec = ClassesAbstratas.Entities;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {    
            Shape rec = new Rec.Rectangle("Azul");
            Shape cir = new Rec.Circle("Vermelho");

            Console.WriteLine($"Forma:{rec}, Cor:{rec.Color}, Area:{rec.Area()}");
            Console.WriteLine($"Forma:{cir}, Cor:{cir.Color}, Area:{cir.Area()}");

            List<Shape> lstShape = new List<Shape>();

            lstShape.Add(new Rectangle("Amarelo"));
            lstShape.Add(new Circle("Marrom"));

            foreach (Shape item in lstShape)
            {
                Console.WriteLine($"Forma:{item}, Cor:{item.Color}, Area:{item.Area()}");
            }



        }

        
        
    }
}
