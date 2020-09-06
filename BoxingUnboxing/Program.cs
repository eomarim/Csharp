using System;

namespace BoxingUnboxing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Object obj = null;
            int x = 10;
            obj = x; //Boxing;

            int y = (int)obj; //Unboxing

            obj = 10.00;
            double z = (double)obj;
        }
    }
}
