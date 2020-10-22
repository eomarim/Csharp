using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Linqs2_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            ICategoria c1 = new Categoria(1, "Ferramentas", 2);
            ICategoria c2 = new Categoria(2, "Computadores", 1);
            ICategoria c3 = new Categoria(3, "Eletronicos", 1);

            IList<IProduto> prods = new List<IProduto>();
            IProduto p1 = new Produto(1, "Computador", 1100.00, c2);
            IProduto p2 = new Produto(2, "Martelo", 90.00, c1);
            IProduto p3 = new Produto(3, "TV", 1700.00, c3);
            IProduto p4 = new Produto(4, "Notebook", 1300.00, c2);
            IProduto p5 = new Produto(5, "Serra", 80.00, c1);
            IProduto p6 = new Produto(6, "Tablet", 700.00, c2);
            IProduto p7 = new Produto(7, "Camera", 700.00, c3);
            IProduto p8 = new Produto(8, "Impressora", 350.00, c3);
            IProduto p9 = new Produto(9, "Macbook", 1800.00, c2);
            IProduto p10 = new Produto(10, "Caixa de Som", 700.00, c3);
            IProduto p11 = new Produto(11, "Nivel", 70.00, c1);

            prods.Add(p1);
            prods.Add(p2);
            prods.Add(p3);
            prods.Add(p4);
            prods.Add(p5);
            prods.Add(p6);
            prods.Add(p7);
            prods.Add(p8);
            prods.Add(p9);
            prods.Add(p10);
            prods.Add(p11);
            
            //Filtro usando Linq
            var r1 = (from y in prods
                                where y.CategoriaProduto.Nivel == 1 && y.Preco < 900
                                orderby y.Nome
                                select y
                    );
            //Filtro usando expressao lambda
            var r2 = prods.Where(x => x.Preco < 900 && x.CategoriaProduto.Nivel == 1);

            //Passando func
            var r3 = prods.Where(FiltraProdutoPrecoNivel);

            //Usando o delegate Fun
            Func<IProduto, bool> fun = FiltraProdutoPrecoNivel;
            var r4 = prods.Where(fun);

            ImprimirDados<IProduto>(r4, "Produtos com Categoria Nivel 1 e Preco Menor 900.00");   

            //Nomes dos Produtos da Categoria Ferramentas

            //Usando linq
            var r5 = (from y in prods
                                where y.CategoriaProduto.Nome.Equals("Ferramentas")
                                orderby y.Nome
                                select y.Nome
            
            );
            //Usando expressao lambda
            var r6 = prods.Where(x => x.CategoriaProduto.Nome.Equals("Ferramentas")).Select(p => p.Nome);

            //Passando Func
            var r7 = prods.Where(FiltraCategoriaFerramentas).Select(p => p.Nome);

            //Delegate
            Func<IProduto, bool> func2 = FiltraCategoriaFerramentas;
            var r8 = prods.Where(func2).Select(p => p.Nome);

            ImprimirDados<string>(r8, "Nomes dos Produtos da Categoria Ferramentas");   

            //Nomes dos Produtos que iniciam com a letra C com campos personalizados

            var r9 = ( from y in prods
                                where y.Nome.StartsWith("C")
                                orderby y.Nome
                                select new {y.Nome, NomeCategoria = y.CategoriaProduto.Nome, y.Preco}
                                                );
            var r10 = prods.Where(p => p.Nome.StartsWith("C")).Select( p => new {p.Nome, NomeCategoria = p.CategoriaProduto.Nome, p.Preco});

            var r11 = prods.Where(FiltrarProdsInitLetraC).Select(p => new {p.Nome, NomeCategoria = p.CategoriaProduto.Nome, p.Preco});

            Func<IProduto, bool> prodInitC = FiltrarProdsInitLetraC;
            var r12 = prods.Where(prodInitC).Select(p => new {p.Nome, CategoriaProduto = p.CategoriaProduto.Nome, p.Preco});

            ImprimirDados<object>(r12, "Nomes dos Produtos que iniciam com a letra C com campos especificos");

            //Produtos de primeira categoria 
            var r13 = (from y in prods
                                where y.CategoriaProduto.Nivel.Equals(1)
                                orderby y.Preco
                                select new {y.Nome, CategoriaProduto = y.CategoriaProduto.Nome, y.Preco}

                        );
            var r14 = prods.Where(p => p.CategoriaProduto.Nivel.Equals(1)).
                                                                        Select(p=> new {p.Nome, 
                                                                                        CategoriaProduto = p.CategoriaProduto.Nome, 
                                                                                        p.Preco}).
                                                                        OrderBy(p => p.Preco). //Ordena por Preco
                                                                        ThenBy(p=> p.Nome); // e depois por nome

            Func<IProduto, bool> prodsNivel1 = ProdutosCategoria1;
            var r15 = prods.Where(prodsNivel1).Select(p=> new {p.Nome, 
                                                               CategoriaNome = p.CategoriaProduto.Nome, 
                                                               p.Preco}).
                                                OrderBy(p=> p.Preco). // ordena por preco
                                                ThenBy(p=> p.Nome); // e depois por nome

            var r16 = prods.Where(ProdutosCategoria1).Select(p=> new {p.Nome, 
                                                                      CategoriaNome = p.CategoriaProduto.Nome, 
                                                                       p.Preco}).
                                                      OrderBy(p => p.Preco). //ordena por preco 
                                                      ThenBy(p => p.Nome); // e depois por nome

            ImprimirDados<object>(r16, "Produtos com a categoria 1");

            //Skip e Take para paginacao, pula 2 e pega 4
            
            var r17 = r16.Skip(2).Take(4);

            ImprimirDados<object>(r17, "Skip e Take para paginacao, pula 2 e pega 4");

            //Pegando primeiro elemento
            var r18 = prods.First();
            System.Console.WriteLine("Pegando primeiro elemento");
            System.Console.WriteLine(r18);

            var r19 = prods.Last();
            System.Console.WriteLine("Pegando o ultimo elemento");
            System.Console.WriteLine(r19);

            //Tentando pegar o ultimo elemento de uma lista vazia usando o last or default para nao ocorrer exception
            var r20 = prods.Where(p => p.Preco > 10000.00).LastOrDefault();
            System.Console.WriteLine(r20);

            var r21 = prods.Where(ProdutosPrecoMaior10000).LastOrDefault();
            
            Func<IProduto, bool> prodPrecoMaior10000 = ProdutosPrecoMaior10000;
            var r22 = prods.Where(prodPrecoMaior10000).LastOrDefault();
            
            //Tentando pegar o primeiro elemento de uma lista vazia usando o last or default para nao ocorrer exception
            var r23 = prods.Where(p => p.Preco > 8000.00).FirstOrDefault();
            System.Console.WriteLine(r21);

            //Single or default - utilizar quando for retornar somente um ou nenhum elemento
            //Retorna um objeto e nao um Enumerable
            var r24 = prods.Where(p => p.Id.Equals(1)).SingleOrDefault();
            System.Console.WriteLine("Single or Default");
            System.Console.WriteLine(r22);

            var r25 = prods.Where(ProdutoId1).SingleOrDefault();
            System.Console.WriteLine(r25);

            //Max
            var r26 = prods.Max(p => p.Preco);
            System.Console.WriteLine("Metodo Max");
            System.Console.WriteLine(r26);

            var r27 = prods.Min(p => p.Preco);
            System.Console.WriteLine("Metodo Min");
            System.Console.WriteLine(r27);

            //Criando agrupamento por Categoria do Produto
            System.Console.WriteLine("Agrupamento por Categorias");
            var r28 = (from y in prods
                                group y by y.CategoriaProduto.Nome into categoriaProds
                    select categoriaProds

            );
            foreach(var item in r28){
                System.Console.WriteLine($"Grupo:{item.Key}");
                foreach (var i in item)
                {
                    System.Console.WriteLine(i);
                }
            }
            //Agrupamento por niveis
            System.Console.WriteLine("Agrupamento por niveis");
            var r29 = (from y in prods
                                group y by y.CategoriaProduto.Nivel into niveis
                      select niveis

            );
            foreach (var item in r29)
            {
                System.Console.WriteLine($"{item.Key}");
                foreach (var i in item)
                {
                    System.Console.WriteLine(i);
                }
            }

            //Funcao de agregacao de soma - somando o total de todos os produtos
            var r30 = (from y in prods
                            where y.CategoriaProduto.Nivel.Equals(1)
                            select y.Preco

            ).Sum();

            System.Console.WriteLine(r30);
            //Outra forma de somar
            var r31 = prods.Where(p => p.CategoriaProduto.Nivel.Equals(1)).Sum(p => p.Preco);
            System.Console.WriteLine(r31);

            var r32 = (from y in prods 
                                        where y.CategoriaProduto.Nivel.Equals(2)
                                        select y.Preco
            ).Sum();
            System.Console.WriteLine("Outra forma de Somar{0}", r32);

            //Somando todos os produtos da categoria de Id 1
            var r33 = prods.Where(p => p.CategoriaProduto.Id.Equals(1)).Sum(p => p.Preco);
            System.Console.WriteLine(r32);

            //Media de precos
            var r34 = prods.Where(p => p.CategoriaProduto.Id.Equals(1)).DefaultIfEmpty().Average(p=> p.Preco);
            System.Console.WriteLine(r33);

            //Outra forma de pegar a media
            var r35 = (from y in prods
                                where y.CategoriaProduto.Nivel.Equals(2)
                                select y.Preco
            //DefaultIfempty para nao gerar exception caso o retorno seja vazio
            ).DefaultIfEmpty().Average();

            System.Console.WriteLine("Outra forma de pegar a media:{0}", r35);

            //Map Reduce - Agregate
            var r36 = (
                from y in prods 
                            where y.Nome.Contains("T")
                            select y.Preco
            ).DefaultIfEmpty().Aggregate((x, y)=> x + y);
            System.Console.WriteLine("Soma dos produtos{0}", r36);

            //Outra forma de agregar
            var r37 =(
                from y in prods
                            where y.CategoriaProduto.Id.Equals(2)
                            select y.Preco
            ).DefaultIfEmpty().Aggregate(SomaProdutos);
            System.Console.WriteLine("Soma dos produtos{0}", r37);

            Func<double, double, double> funcSomar = SomaProdutos;
            //Outra forma de agregar
            var r38 =(
                from y in prods
                            where y.Nome.ToUpper().Contains("XPTO")
                            select y.Preco
            //Usando DefaultIfEmpty para tratar caso venha zero ou podemos passar um valor padrao 
            ).Aggregate(0.00,funcSomar);
            //ou ).DefaultIfEmpty().Aggregate(funcSomar);

            System.Console.WriteLine("Soma de todos os produtos que contem 'XPTO no nome:{0}", r38);

            System.Console.WriteLine("Agrupamento por precos");
            var r39 = (from y in prods
                                    group y by y.Preco into precos
                                    select precos

            );
            foreach (var item in r39)
            {
                System.Console.WriteLine("Preco:" + item.Key);
                foreach (var p in item)
                {
                    System.Console.WriteLine(p);
                }
            }
            //Outra forma de montar o foreach
            System.Console.WriteLine("Outra forma de montar um foreach");
            foreach (IGrouping<double,IProduto> preco in r39)
            {
                System.Console.WriteLine($"{preco.Key}:");
                foreach (var item in preco)
                {
                    System.Console.WriteLine(item.Nome);
                }
            }

        }

        public static double SomaProdutos(double x, double y)=> x + y;

        public static bool ProdutoId1(IProduto prod) => prod.Id.Equals(1);

        public static bool ProdutosPrecoMaior10000(IProduto prod)=> prod.Preco > 10000.00;

        public static bool ProdutosCategoria1(IProduto prod) => prod.CategoriaProduto.Nivel.Equals(1);

        public static bool FiltraProdutoPrecoNivel(IProduto prod){
            return prod.Preco < 900 && prod.CategoriaProduto.Nivel == 1;
        }

        public static bool FiltraCategoriaFerramentas(IProduto prod){
            return prod.CategoriaProduto.Nome.Equals("Ferramentas");
        }

        public static bool FiltrarProdsInitLetraC(IProduto prod) => prod.Nome.StartsWith("C");
        

        static void ImprimirDados<T>(IEnumerable<T> lst, string mensagem ){
            System.Console.WriteLine("");
            System.Console.WriteLine($"$$$$$ {mensagem} $$$$$");
            foreach (var item in lst)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("");
        }
    }

    public interface IProduto
    {
        int Id { get; set; }
        string Nome { get; set; }
        double Preco { get; set; }
        ICategoria CategoriaProduto { get; set; }

        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }

    public class Produto : IProduto, IComparable
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public ICategoria CategoriaProduto { get; set; }
        public Produto(int id, string nome, double preco, ICategoria categoria)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            CategoriaProduto = categoria;
        }

        public override string ToString()
        {
            return $"Id:{Id}, Nome:{Nome}, Preco:{Preco},"
                + $"Categoria Nome:{CategoriaProduto.Nome}, Categoria Nivel:{CategoriaProduto.Nivel}";
        }

        public override bool Equals(object obj)
        {
            return obj is Produto produto &&
                   Id == produto.Id &&
                   Nome == produto.Nome;

        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome);
        }

        public int CompareTo(object obj){
            var other = obj as Produto;

            return other.Nome.CompareTo(Nome);
        }
    }

    public interface ICategoria
    {
        int Id { get; set; }
        string Nome { get; set; }
        int Nivel { get; set; }

        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }

    public class Categoria : ICategoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public Categoria(int id, string nome, int nivel)
        {
            Id = id;
            Nome = nome;
            Nivel = nivel;

        }
        public override bool Equals(object obj)
        {
            return obj is Categoria categoria &&
                   Id == categoria.Id &&
                   Nome == categoria.Nome;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome);
        }

        public override string ToString()
        {
            return $"Id:{Id}, Nome:{Nome}, Categoria:{Nivel}";
        }
    }
}
