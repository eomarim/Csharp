using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;

namespace Listas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var listaFabricantes = new List<string>{"Volkswagem", "Audi", "Kia"};
            listaFabricantes.Insert(0, "Ford");
            listaFabricantes.Insert(1, "Fiat");

            System.Console.WriteLine($"Tamanho da lista de fabricantes: {listaFabricantes.Count}");

            foreach (string item in listaFabricantes)
            {
                System.Console.WriteLine(item);
            }

            //Find
            
                                                            //Passando uma funcao criada
           // fabricanteComecaLetraF = listaFabricantes.Find(Fabricante);
                                                            //Formato Lambda
            string fabricanteComecaLetraF = listaFabricantes.Find(x => x[0] == 'F'); //Recebe uma funcao //Pesquisando primeiro valor que inicie com A

            string fabricanteTerminaLetraF = listaFabricantes.FindLast(x => x[0] == 'F');

            System.Console.WriteLine($"Primeiro Fabricante da Lista encontrado com a Letra F: {fabricanteComecaLetraF}");
            System.Console.WriteLine($"Ultimo fabricante da Lista que inicia com a letra F: {fabricanteTerminaLetraF} " );

            var listaCarros = new List<string>(){"Lamborguini", "Ferrari", "Kadenza", 
                "LOGAN", "TUCSON", "L200", "HILUX"};
            listaCarros.Add("Golf");
            listaCarros.Add("Audi A3");
            listaCarros.Add("Cerato");
            listaCarros.Add("Soul");
            listaCarros.Insert(2, "Passat");
            //listaCarros.Insert(7, "I30"); //Erro ao tentar inserir valor fora do tamanho da lista

            System.Console.WriteLine("--------------------------------------------------");

            System.Console.WriteLine($"Tamanho da Lista de Carros: {listaCarros.Count}");
            foreach (string item in listaCarros)
            {
                Console.WriteLine(item);    
            }
            
            //FindAll
            List<string> lstFiltro = listaCarros.FindAll(x => x.Length == 6);
            foreach (string item in lstFiltro)
            {
                System.Console.WriteLine($"Veiculos com o nome de 6 caracteres: {item}" );
            }

            lstFiltro = listaCarros.FindAll(x => x.ToUpper().Contains("A"));

            foreach (string item in lstFiltro)
            {
                System.Console.WriteLine($"Contem letra A no nome: {item}");
            }

            lstFiltro = listaCarros.FindAll(x => x.ToUpper().Contains(" "));
            foreach (string item in lstFiltro)
            {
                System.Console.WriteLine($"Nome de Fabricante Contem Espaco: {item}");
            }

            //Remove
            string carroRemove = "Passat";
            listaCarros.Remove(carroRemove);
            System.Console.WriteLine($"Carro a ser removida da Lista: {carroRemove}");
            foreach (string item in listaCarros)
            {
                System.Console.WriteLine($"Carro: {item}" );
            }

            //RemoveAll
            listaCarros.RemoveAll(x => x.StartsWith("A"));
            System.Console.WriteLine($"Carro a ser removida da Lista que Iniciam com a letra A");
            foreach (string item in listaCarros)
            {
                System.Console.WriteLine($"Carro: {item}");
            }

            //RemoveAt
            int posicaoCarroRemove = 0;
            System.Console.WriteLine($"Posicao do Carro a ser removido: {posicaoCarroRemove} ");
            listaCarros.RemoveAt(0);

            foreach (string item in listaCarros)
            {
                System.Console.WriteLine($"Carro: {item}");
            }

            //RemoveRange
            listaCarros.RemoveRange(0, 2);
            System.Console.WriteLine($"Carros a serem removidos, posicao 0, remover 2 veiculos");
            foreach (string item in listaCarros)
            {
                System.Console.WriteLine($"Carro: {item} ");
            }
        }

        internal static bool BuscaPrimeiroCaractere(string fabricante){
            return fabricante[0] == 'A';
        }
    }
}
