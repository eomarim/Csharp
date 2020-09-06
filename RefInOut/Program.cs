using System.Net.NetworkInformation;
using System;

namespace RefInOut
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ref precisa que o parametro informado tenha uma atribuicao;
            int x = 5;
            ValorPorReferencia_Ref(ref x);
            Console.WriteLine($"Valor de X passado por referencia(Ref) do Metodo Valor Por Referencia: {x}" );

            int y; //out - nao precisa ser inicializado. E util quando queremos que o metodo retorne mais de um valor
            ValorPorReferencia_Out(out y);
            Console.WriteLine($"Valor de y passado por referencia(Out) do Metodo Valor Por Referencia: {y}" );
        }

        public static void ValorPorReferencia_Ref(ref int valor){
            valor = 10;
        }

        public static void ValorPorReferencia_Out(out int valor){
            valor = 20;
        }
    }
}
