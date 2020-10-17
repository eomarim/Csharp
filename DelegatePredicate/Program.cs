using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace DelegatePredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstProd = new List<Produto>();
            lstProd.Add(new Produto("TV", 4500.00));
            lstProd.Add(new Produto("Notebook", 5200.00));
            lstProd.Add(new Produto("Macbook", 3100.00));
            lstProd.Add(new Produto("Mouse", 99.00));

            lstProd.Sort();

            //Usando Lambda
            //lstProd.RemoveAll(x => x.Preco <=100);

            //passando um Predicate delegate - metodo statico boleano
            lstProd.RemoveAll(RemoveProdutosLista);

            foreach (Produto item in lstProd)
            {
                System.Console.WriteLine(item);
            }
            
        }
        public static bool RemoveProdutosLista(Produto objProd){
            return objProd.Preco <= 100.00;
        }
    }

    public class Produto : IComparable{
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto(string descricao, double preco)
        {
            this.Descricao = descricao; 
            this.Preco = preco;
        } 
    
        public override string ToString() => $"Descricao:{Descricao}, Preco:{Preco}";

        public override int GetHashCode() => HashCode.Combine(Descricao);
        
        public override bool Equals(object obj)
        {            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
                var objProd = obj as Produto;
                

            return Descricao.Equals(objProd.Descricao);
        }

        public int CompareTo(object obj){
            if(obj != null && obj.GetType() != this.GetType())
                return 0;

            var objProd = obj as Produto;

            return Descricao.CompareTo(objProd.Descricao);
        }


    }
}
