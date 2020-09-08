using System;

namespace Matrizes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double [,] matriz = new double[2,3];
            System.Console.WriteLine(matriz.Length); //Tamanho da Matriz
            System.Console.WriteLine(matriz.IsFixedSize);
            System.Console.WriteLine(matriz.LongLength);
            System.Console.WriteLine("Quantidade de Linhas:" + matriz.Rank); //Primeira dimensao que e a quantidade de linhas
            System.Console.WriteLine("Tamanho da primeira dimensao: " + matriz.GetLength(0));
           
            System.Console.Write("Digite a quantidade de posicoes da Matriz:");
            int posicoesMatriz = int.Parse(Console.ReadLine());
            
            double[,] matriz2 = new double[posicoesMatriz, posicoesMatriz];

            for (int i = 0; i < posicoesMatriz; i++)
            {
                for (int j = 0; j < posicoesMatriz; j++)
                {
                    System.Console.Write($"Preencha a linha {i} da Matriz:");
                    matriz2[i, j] =  int.Parse(Console.ReadLine());    
                }                
            }

            System.Console.WriteLine("-------Numeros Diagonais-------");

            for (int i = 0; i < posicoesMatriz; i++)
            {
                System.Console.Write(matriz2[i,i] + " ");
            }
            
            Console.WriteLine("");

            System.Console.WriteLine("-------Numeros Negativos--------");

            int contar = 0;
            for (int i = 0; i < posicoesMatriz; i++)
            {
                for (int j = 0; j < posicoesMatriz; j++)
                {
                    if(matriz2[i, j] < 0)
                        contar++;
                }
            }

            System.Console.WriteLine($"Quantidade de numeros negativos:{contar}");

            System.Console.WriteLine("-------Matriz Inteira-----------");

            //Mostrar matriz inteira
            for (int i = 0; i < posicoesMatriz; i++)
            {
                System.Console.WriteLine("");

                for (int j = 0; j < posicoesMatriz; j++)
                {
                    Console.Write($"{matriz2[i,j]} ");
                }
            }
            Console.WriteLine("");  
        }

    }
}
