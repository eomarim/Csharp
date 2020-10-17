using System.Linq;
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

                var cal = new CalculationService();
            DelContar c = cal.Contar;
            c(15);

            //Call back
            Del del = new Del(CalculationService.DelegateMethod);
            CalculationService.MethodWithCallback(10, 10, del);

            ReferenciaMetodo delRefMethod = CalculationService.DelegateMethod;
            CalculationService.ChamaDelegate("Passei o metodo ChamaDelegate", 
            "para o Delegate Referencia Metodo", delRefMethod);

            Del d1 = CalculationService.DelegateMethod;
            Del d2 = CalculationService.DelegateMethod2;
            Del d3 = CalculationService.DelegateMethod2;

            Del d4 = d1 + d2 + d3;

            System.Console.WriteLine(d2 == d3);

            d4.Invoke("Invocando metodos");
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

       public static void DelegateMethod(string x){
           System.Console.WriteLine("Metodo 1");
       }

       public static void DelegateMethod2(string x){
           System.Console.WriteLine("Metodo 2");
       }

       public void Contar(int x){
           for (int i = 0; i < x; i++)
           {
               System.Console.Write(i.ToString() + " ");
           }
       }

       public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

        public static void ChamaDelegate(string x, string y, ReferenciaMetodo del ){
            del.Invoke("Chamada de um delegate:" + x + y);
        }
       
    }
     public delegate double DelCalculo(double x, double y);

     public delegate void MostrarNumeros(double x, double y);

     public delegate void DelContar(int x);

     public delegate void Del(string s);

     public delegate void ReferenciaMetodo(string y);


}
