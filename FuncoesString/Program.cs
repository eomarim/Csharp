using System;

namespace FuncoesString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string texto = "    abc DEF ghi JLM    ";
            string caixaAlta = texto.ToUpper(); //tudo caixa alta
            string caixaBaixa = texto.ToLower(); //tudo caixa baixa
            string semEspacosLaterais = texto.Trim(); //retira espacos laterais
            string semEspacosDireita = texto.TrimEnd(); //Retirar espacos no final
            string semEspacosEsquerda = texto.TrimStart();
            int posicaoString = texto.IndexOf("gh");
            bool comecaPorAlgumValor = texto.StartsWith("   "); //true, porque a var texto comeca com vazio....
            bool terminaComAlgumValor = texto.EndsWith("M"); //false, pois termina com vazio...
            bool containAlgumValor = texto.Contains("DE");//true contem as letras DE
            bool testaIgualdade = texto.Equals("    abc DEF ghi JLM    ");//true, igual ao conteudo da variavel texto...
            string[] separar = texto.Split(" "); //Faz a separacao por espacos e atribui a lista
            string cortarTexto = texto.Substring(0, 5);//Corta a string a partir de um ponto - Comecando na posicao 0, corta 5 caracteres
            int ultimaOcorrenciaString = texto.LastIndexOf("JL");//Procura a ultima ocorrencia de JL
            string substituir = texto.Replace("abc", "wyz");//Substitui abc por wyz
            bool eNulo = string.IsNullOrEmpty(texto); //Verifica se e nulo ou vazio
            bool eNuloVazio = string.IsNullOrWhiteSpace(texto); //verifica se e nulo ou somente possui espacos em branco

            System.Console.WriteLine($"Conteudo da variavel Texto: -{texto}-");
            System.Console.WriteLine($"Conteudo da variavel texto em caixa alta: -{caixaAlta}-");
            System.Console.WriteLine($"Conteudo da Variavel texto em caixa baixa: -{caixaBaixa}-");
            System.Console.WriteLine($"Retirando espacos laterais do texto: -{semEspacosLaterais}-");
            System.Console.WriteLine($"Retirando espacos a direita do texto: -{semEspacosDireita}-");
            System.Console.WriteLine($"Retirando espacos a esquerda do texto: -{semEspacosEsquerda}-");
            System.Console.WriteLine($"Posicao dos caracteres: {posicaoString}" );
            System.Console.WriteLine($"Comeca por algum valor? {comecaPorAlgumValor}");
            System.Console.WriteLine($"Termina com algum valor? {terminaComAlgumValor}");
            System.Console.WriteLine($"Contem algum valor ? {containAlgumValor}");
            System.Console.WriteLine($"E igualao conteudo ? {testaIgualdade}");

            System.Console.WriteLine("-------Separado por espacos------");
            foreach (string item in separar)
            {
                System.Console.Write($"{item} - ");
            }

            System.Console.WriteLine($"Corta String: {cortarTexto}");
            System.Console.WriteLine($"Ultima ocorrencia de um valor: {ultimaOcorrenciaString}");
            System.Console.WriteLine($"Substitui ABC por WYZ {substituir}");
            System.Console.WriteLine($"Texto e nulo? {eNulo}");
            System.Console.WriteLine($"E nulo ou possui somente espacos em branco? {eNuloVazio}");
        }
    }
}
