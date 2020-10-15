using System;

namespace Delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formas de usar o delegate
            //1 
            DelCalculo somar = CalculationService.Somar;
            System.Console.WriteLine(somar(10, 20));
            //2 - com o new 
            DelCalculo somar2 = new DelCalculo(CalculationService.Somar);
            System.Console.WriteLine(somar2(10, 21));
            //3 com o invoke
            DelCalculo somar3 = CalculationService.Somar;
            System.Console.WriteLine(somar3.Invoke(10, 22));

            //Multi referencias com delegate
            MostrarNumeros mostrar = CalculationService.MostrarMenor;
            mostrar += CalculationService.MostrarMaior;
            mostrar += CalculationService.MostrarNumeroPar;
            mostrar += CalculationService.MostrarNumeroImpar;

            mostrar.Invoke(12, 13);
        }
    }
    public class CalculationService{
       public static double Somar(double x, double y){
           return x + y;
       }

       public static double Multiplicar(double x, double y){
           return x * y;
       }

       public static void MostrarMaior(double x, double y){
           System.Console.WriteLine("O Maior e:" + ((x>y) ? x : y).ToString());
       }
       public static void MostrarMenor(double x, double y){
           System.Console.WriteLine("O Menor e:" + ((x<y) ? x : y).ToString());
       }

       public static void MostrarNumeroPar(double x, double y){
           System.Console.WriteLine("Numero Par:" + ((x % 2 == 0 ? x : y % 2 == 0 ? y : 0).ToString()));
       }

      public static void MostrarNumeroImpar(double x, double y){
           System.Console.WriteLine("Numero Impar:" + ((x % 2 != 0 ? x : y % 2 != 0 ? y : 0).ToString()));
       }
       
    }
     public delegate double DelCalculo(double x, double y);

     public delegate void MostrarNumeros(double x, double y);
}
