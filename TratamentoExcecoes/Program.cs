using System;

namespace TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = 1;
                int n2 = 0;
                int result = 0; //n1 / n2;

                System.Console.WriteLine(result.ToString());

                int n3 = int.Parse(Console.ReadLine());
                
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("Divisao por zero!");
                
            }
            catch(FormatException)
            {
                System.Console.WriteLine("Format Exception");
            }
            catch(InvalidCastException)
            {
                System.Console.WriteLine("Invalid Casting Exception");
            }
            finally{
                System.Console.WriteLine("Programa finalizou!");
            }
            

        }
    }
}
