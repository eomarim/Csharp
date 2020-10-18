using System.Text;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Linqs
{
    class Program
    {
        static void Main(string[] args)
        {
            //especificar o data source
            int[] numbers = new int[]{10, 2, 4, 7, 54};

            //especificar a consulta
            Func<int, int> func = RetornaPar;
            List<int> lstNumbers  = numbers.Select(RetornaPar).ToList();

            System.Console.WriteLine("Numeros pares multiplicados por 10");
            foreach (var item in lstNumbers)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine(".....Numeros Pares....");
            
            //Passando um metodo
            List<int> lstPares = numbers.Where(isPar).ToList();

              foreach (var item in lstPares)
            {
                System.Console.WriteLine(item);
            }

            //Passando um Predicado lambda
            System.Console.WriteLine("Numeros pares multiplicados por 10");
            //Usando funcao
            //List<int> nums = numbers.Where(x => x % 2 == 0).Select(Multiplicador).ToList();
            //Expressao lambda
            IEnumerable<int> nums = (numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10)
                );

            //Execucao da consulta
            foreach (var item in nums)
            {
                System.Console.WriteLine(item);
            }

            ConsultaLinq1();

            ConsultaLinq2();

            ConsultaLinq3();

            ConsultaLinq4();
          
        }

        public static int RetornaPar(int i){
            if(i % 2 == 0){
                i = i * 10;
            } 

            return i;   
        }

        public static bool isPar(int i){
            bool testa = false;
            if(i % 2 == 0){
                testa = true;
            }
            return testa;
        }

        public static int Multiplicador(int i)=> i * 10;

        public static void ConsultaLinq1(){
            string[] str = new string[]
                    {"Eduardo Oliveira Marim", 
                    "Luzia Odete de Oliveira", 
                    "Moacir Marim",
                    "Moacir Marim Junior"};
            var x = (from s in str
                        where s.Contains("Marim")
                        select s
                    );

            System.Console.WriteLine("...Consulta Linq 1...");

            System.Console.WriteLine("Mostrando array");
            foreach (var item in str)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Consulta com Linq");

            foreach (var item in x)
            {
                System.Console.WriteLine(item);
            }
        }

        public static void ConsultaLinq2(){
            IAutomovel auto1 = new Carro("Kia", "Cerato", "Branco");
            IAutomovel auto2 = new Carro("Volkswagen", "Passat", "Preto");
            IAutomovel auto3 = new Carro("Chevrolet", "Vectra", "Azul");
            IAutomovel auto4 = new Carro("Volkswagen", "Golf", "Branco");
            IAutomovel auto5 = new Carro("Hyundai", "Elantra", "Branco");

            IList<IAutomovel> lstAutomoveis = new List<IAutomovel>();

            lstAutomoveis.Add(auto1);
            lstAutomoveis.Add(auto2);
            lstAutomoveis.Add(auto3);
            lstAutomoveis.Add(auto4);
            lstAutomoveis.Add(auto5);

            System.Console.WriteLine("...Consulta Linq 2...");

            System.Console.WriteLine("...Mostrando todos os veiculos...");
            foreach (IAutomovel item in lstAutomoveis)
            {
                System.Console.WriteLine(item); 
            }

            var x = from aut in lstAutomoveis
                                where aut.Cor == "Branco" && 
                                                        (aut.Modelo.Contains("a") 
                                                            || aut.Modelo.Contains("o"))
                                orderby aut.Modelo
                                select aut;
            System.Console.WriteLine("...Filtrando com linq...");
            foreach (var item in x)
            {
                System.Console.WriteLine(item);
            }

        }

        public static void ConsultaLinq3(){
            IList<IEsporte> lstEsp1 = new List<IEsporte>();
            IEsporte espQ = new TenisQuadra("Tenis de Quadra");
            IEsporte espS = new TenisSaibro("Tenis de Saibro");
            lstEsp1.Add(espQ);
            lstEsp1.Add(espS);

            IList<IEsporte> lstEsp2 = new List<IEsporte>();
            lstEsp1.Add(espS);

            IList<IAtleta> lstAtleta = new List<IAtleta>();
            IAtleta atTenis1 = new Tenista("Guga", 50, lstEsp1);
            IAtleta atTenis2 = new Tenista("Eduardo", 35, lstEsp1);
            IAtleta atTenis3 = new Tenista("Moacir", 65, lstEsp2);

            lstAtleta.Add(atTenis1);
            lstAtleta.Add(atTenis2);
            lstAtleta.Add(atTenis3);

            System.Console.WriteLine("...Consulta Linq 3...");
            System.Console.WriteLine("....Lista de Atletas....");
            foreach (var item in lstAtleta)
            {
                System.Console.WriteLine(item);
            } 

            System.Console.WriteLine("...Lista de Atletas Filtrados com Linq...");
            var x = from y in lstAtleta
                                where y.Idade > 35  
                                orderby y.Nome descending
                                select y;

            foreach (var y in x)
            {
                System.Console.WriteLine(y);
            }
        }

        public static void ConsultaLinq4(){

            IList<IEsporte> lstEsp1 = new List<IEsporte>();
            IEsporte espQ = new TenisQuadra("Tenis de Quadra");
            IEsporte espS = new TenisSaibro("Tenis de Saibro");
            lstEsp1.Add(espQ);
            lstEsp1.Add(espS);

            IList<IEsporte> lstEsp2 = new List<IEsporte>();
            lstEsp2.Add(espS);

            IList<IEsporte> lstEsp3 = new List<IEsporte>();
            lstEsp3.Add(espQ);

            IList<IAtleta> lstAtleta = new List<IAtleta>();
            IAtleta atTenis1 = new Tenista("Guga", 50, lstEsp1);
            IAtleta atTenis2 = new Tenista("Eduardo", 35, lstEsp2);
            IAtleta atTenis3 = new Tenista("Moacir", 65, lstEsp3);

            lstAtleta.Add(atTenis1);
            lstAtleta.Add(atTenis2);
            lstAtleta.Add(atTenis3);

            System.Console.WriteLine("...Consulta Linq 4...");
            //Consultando lista de objetos dentro de objeto
            var result = lstAtleta
                            .Where(x =>  x.Nome.Contains("M") 
                                &&  x.Esportes.Where(y => y.Descricao.Contains("Qu")).Count() > 0).ToList();

        //result = paises.Where(x => x.Estados.Where(y => y.Cidades.Where(o => o.Nome == "California").Count() > 0).Count() > 0).ToList();

            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }

        }
}
    public interface IAutomovel{

        string Marca { get; set; }
        string Modelo { get; set; }
        string Cor{get; set;}
        void Ligar();
         
    }
    public abstract class Veiculo : IAutomovel{
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor{get; set;}
        public Veiculo(string marca, string modelo, string cor){
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
        }

        public void Ligar(){}

          public override string ToString()
        {
            return $"Fabricante:{Marca}, Modelo:{Modelo}, Cor:{Cor}";
        }
    }

    public class Carro : Veiculo{

        public Carro(string marca, string modelo, string cor): base (marca, modelo, cor){}
        public void Ligar(){
            System.Console.WriteLine("Carro Ligado!");
        }

    }

    public interface IEsporte{
        string Descricao { get; set; }
        
    }

    public abstract class Tenis : IEsporte{
        public string Descricao { get; set; }
        public Tenis(string descricao) => Descricao = descricao;
            
        public override string ToString()=> $"Descricao:{Descricao} ";
        
    }
    public class TenisQuadra : Tenis{
        public TenisQuadra(string descricao):base(descricao){}
    }
    public class TenisSaibro : Tenis{
        public TenisSaibro(string descricao):base(descricao){}
    }

    public interface IAtleta{
        string Nome { get; set; }
        int Idade { get; set; }
        IList<IEsporte> Esportes { get; set; }
        void Jogar();
    }

    public class Tenista : IAtleta{
        public string Nome { get; set; }
        public int Idade { get; set; }
        public IList<IEsporte> Esportes { get; set; }
        public Tenista(string nome, int idade, IList<IEsporte> esportes){
            Nome = nome;
            Idade = idade;
            Esportes = esportes;
        }
        public void Jogar(){
            System.Console.WriteLine("Tenista Jogando");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nome:" + Nome);
            sb.Append(",Idade:" + Idade.ToString());
            sb.Append(",Esportes:");

            if(Esportes != null){
                foreach (var item in Esportes)
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();
        }
        
    }

}
