using System.Collections.Generic;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
           var c = new PrintService<string>();
           c.AddValor("Maria");
           c.AddValor("Joao");
           c.AddValor("Renata");

           System.Console.WriteLine($"First:{c.First()}");

           c.Print();

        }
    }

    public class PrintService<T>{
        private List<T> LstInt { get;  set; }

        public PrintService(){
            LstInt = new List<T>();
        }
        public void AddValor(T i){
           
            LstInt.Add(i);
        }

        public T First(){

            return LstInt[0];
        }

        public void Print(){
            int posicoes = LstInt.Count;
            int contador = 0;

            System.Console.Write("[");
            foreach (T item in LstInt)
            {
                contador++;
                if(contador != posicoes)
                    System.Console.Write(item.ToString() + ",");
                else
                    System.Console.Write(item.ToString());
            }
            System.Console.Write("]");
        
        }
    }
}

