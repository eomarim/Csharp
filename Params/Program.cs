using System.Globalization;
using System;

namespace Params
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Console.WriteLine(      Soma(10, 55.3, 20.6, 10.25).ToString("F2", CultureInfo.InvariantCulture)       );
        }
                                //Informe params e passe somente os valores
        public static double Soma(params double[] numeros){
            double resultado = 0.00;

            for (int i = 0; i < numeros.Length; i++)
            {
                resultado+= numeros[i];
            }
            return resultado;
        }
    }
}
