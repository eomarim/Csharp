using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace Linqs3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProduto> lstProd = LerCSV(@"/Users/eduardomarim/Programacao/CSharp/Linqs3/produtos.csv");

            System.Console.WriteLine("Lista de Produtos do CSV");
            foreach (var item in lstProd)
            {
                System.Console.WriteLine(item);
            }

            //Usando linq com a funcao media
            var precoMedioProdutos = (from y in lstProd
                                        select y.Preco
            ).DefaultIfEmpty(0.00).Average();
            System.Console.WriteLine("Media do precoso dos produtos:{0}", precoMedioProdutos);

            //Passando um lambda para a funcao 
            var precoMedioProdutos2 = lstProd.Select(p => p.Preco).DefaultIfEmpty(0.00).Average();
            System.Console.WriteLine("Outra forma de fazer a media do preco dos produtos: " + precoMedioProdutos2);
            
            //Passando uma funcao
            var precoMedioProdutos3 = lstProd.Select(ValorProduto).DefaultIfEmpty(0.00).Average();
            System.Console.WriteLine("Outra forma de fazer a media do preco dos produtos: " + precoMedioProdutos3);

            //Passando um delegate
            Func<IProduto, double> funcPreco = ValorProduto;
            var precoMedioProdutos4 = lstProd.Select(funcPreco).DefaultIfEmpty(0.00).Average();
            System.Console.WriteLine("Outra forma de fazer a media do preco dos produtos: " + precoMedioProdutos4);

            var nomeProdutos = (from y in lstProd
                                where y.Preco < precoMedioProdutos4
                                orderby y.Nome descending
                                select y.Nome
            );
            System.Console.WriteLine("Nome dos produtos que estao com o preco abaixo da media");
            Ler<string>(nomeProdutos);

            System.Console.WriteLine("Outra forma");
            
            var nomeProdutosAbaixoMedia2 = lstProd.
                                                Where(y => y.Preco < precoMedioProdutos4).
                                                OrderByDescending(p => p.Nome).ThenByDescending(p => p.Preco).
                                                Select(p => p.Nome);
                                                

            Ler<string>(nomeProdutosAbaixoMedia2);

            System.Console.WriteLine("Mais uma forma");
            var nomeProdutosAbaixoMedia3 = lstProd.
                                                Where(y => y.Preco < precoMedioProdutos4).
                                                OrderByDescending(NomeProd).
                                                ThenByDescending(PrecoProd).
                                                Select(NomeProd);

            Ler<string>(nomeProdutosAbaixoMedia3);

            System.Console.WriteLine("Ultima forma");

            Func<IProduto, string> funcOrderNome = NomeProd;
            Func<IProduto, double> funcOrderPreco = PrecoProd;

            var nomeProdutosAbaixoMedia4 = lstProd.Where(p => p.Preco < precoMedioProdutos4).
                                                        OrderByDescending(funcOrderNome).
                                                        ThenByDescending(funcOrderPreco).
                                                        Select(NomeProd);
            Ler<string>(nomeProdutosAbaixoMedia4);

        }

        public static string NomeProd(IProduto p)=> p.Nome;

        public static double PrecoProd(IProduto p)=> p.Preco; 
        public static void Ler<T>(IEnumerable<T> lst){
            foreach (var item in lst)
            {
                System.Console.WriteLine(item);
            }
        }
        public static List<IProduto> LerCSV(string path){
            string linha = string.Empty;
            var lstProd = new List<IProduto>();
            using(StreamReader sr = File.OpenText(path)){
              while((linha = sr.ReadLine()) != null){
                  string[] prod = linha.Split(new char[]{',', ';'});
                  lstProd.Add(new Produto(prod[0], double.Parse(prod[1])));
              }
            }
            return lstProd;
        }

        public static double ValorProduto(IProduto p) => p.Preco;
    }

    public interface IProduto
    {
        string Nome { get; set; }
        double Preco { get; set; }

        int CompareTo(object obj);
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
       
    }

    public class Produto : IComparable, IProduto
    {

        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        

        public override bool Equals(object obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }

        public override string ToString()
        {
            return $"Nome:{Nome}, Preco:{Preco}";
        }
        public int CompareTo(object obj) {
            var produto  = obj as Produto;
            
            return Nome.CompareTo(produto.Nome);
        }


    }
}
