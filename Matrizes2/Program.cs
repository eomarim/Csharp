using System;

namespace Matrizes2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] matriz = new int[, ]{{1, 2, 8}, {5, 4, 7}, {35, 41, 87}};

            System.Console.WriteLine($"Quantidade de linhas da matriz: {matriz.GetLength(0)}");
            System.Console.WriteLine($"Quantidade de Colunas da matriz: {matriz.GetLength(1)}");

            //Matriz inteira ordem de inicializacao
            System.Console.WriteLine("Impressao da Matriz");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine("");

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    System.Console.Write($"{matriz.GetValue(i, j)} ");    
                }
            }

            System.Console.WriteLine("");
            
            System.Console.WriteLine("Imprimindo a matriz de forma invertida");

            for (int i = matriz.GetLength(0)-1; i <= matriz.GetLength(0); i--)
            {
                Console.WriteLine("");

                if(i < 0 )
                    break;    
                    

                for (int j = matriz.GetLength(1)-1; j <= matriz.GetLength(1); j--)
                {
                    if(j < 0 )
                        break;

                    System.Console.Write($"{matriz[i, j]} ");    
                }
            }

            System.Console.WriteLine("");

            System.Console.WriteLine("Procurando numero dentro da matriz");

            string posicao = "";
            string esquerda = "";
            string direita = "";
            string abaixo = "";
            string acima = "";

            //2 //4

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                   if(matriz[i,j] == 87 || matriz[i,j] == 2){
                            
                            posicao = $"({i},{j})"; 
                            Console.WriteLine(posicao);   

                        if(j > 0){                            
                            esquerda = $"Left: {matriz[i,j-1]})"; 
                            System.Console.WriteLine(esquerda);
                        }
                        
                        if(j < matriz.GetLength(1) - 1){
                                direita = $"Right: {matriz[i,j+1]})"; 
                            System.Console.WriteLine(direita);
                        }
                            
                        if(i > 0){
                            acima = $"Acima: {matriz[i-1,j]})";  
                                System.Console.WriteLine(acima);
                        }
                                
                        if(i < matriz.GetLength(0)-1){
                                abaixo = $"Abaixo: {matriz[i+1,j]})";  
                                System.Console.WriteLine(abaixo);
                            }  
                   }    

                }
            }

        }
    }
}
