using System.Collections.Generic;
using System;

namespace DelegateComparassionSort1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstProd = new List<Produto>();
            lstProd.Add(new Produto("Caderno", 13.00));
            lstProd.Add(new Produto("Lapis", 3.00));
            lstProd.Add(new Produto("Porta Caneta", 17.00));
            lstProd.Add(new Produto("Borracha", 2.50));

            //Formas de Implementar a funcao de comparacao
            
            //1- Passando a funcao diretamente para o metodo
            //lstProd.Sort(ComparadorProdutos);

            //2- Passando a funcao para o delegate Comparison
            //Comparison<Produto> prod = ComparadorProdutos;
            //lstProd.Sort(prod);

            //3- Passando uma expressao Lambda direto na funcao ou para o delegate
            //lstProd.Sort((p1, p2) => p1.Descricao.CompareTo(p2.Descricao));
            Comparison<Produto> comp = (p1, p2) => p1.Descricao.CompareTo(p2.Descricao);
            lstProd.Sort(comp);
            
            foreach (var item in lstProd)
            {
                System.Console.WriteLine(item);
            }
        }
        public static int ComparadorProdutos(Produto p1, Produto p2){
            return p1.Descricao.CompareTo(p2.Descricao);
        }
    }
           public class Produto{
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto(string descricao, double preco){
            this.Descricao = descricao;
            this.Preco = preco;
        }

        public override string ToString()
        {
            return $"Descricao: {Descricao}, Preco: {Preco}";
        }
    }
}
