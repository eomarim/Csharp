using System.IO;
using System.Collections.Generic;
using System;

namespace Dicionarios
{
    class Program
    {
        static void Main(string[] args)
        {/*
            var cookies = new Dictionary<string, string>();
            
            cookies["user"] = "Eduardo";
            cookies["email"] = "e.oliveiramarim@gmail.com";
            cookies["phone"] = "11 9 95981173";
            cookies["phone"] = "11 9 95981172";

            System.Console.WriteLine(cookies["phone"]);
            System.Console.WriteLine(cookies["email"]);

            cookies.Remove("email");
            
            if(cookies.ContainsKey("email"))
                System.Console.WriteLine(cookies["email"]);
            else
                System.Console.WriteLine("there is not key valeu email in the List");

            System.Console.WriteLine($"Cookie size:{cookies.Count}");

            //1 forma de iterar sobre um Dictionary
            foreach (KeyValuePair<string, string> item in cookies){
                System.Console.WriteLine($"Key:{item.Key}, Value: {item.Value}" );
            }
            //2 forma de iterar sobre um Dictionary
            foreach (var item in cookies){
                System.Console.WriteLine($"Key:{item.Key}, Value: {item.Value}" );
            }

            

            */
            LerResultadoVotos();
          
        }

        public static void LerResultadoVotos(){
            var dicVotos = new Dictionary<string, int>();
            using(var read = new StreamReader(@"/Users/eduardomarim/Programacao/CSharp/Dicionarios/resultadoVotos.txt")){
                while (!(read.EndOfStream))
                {
                    string [] candidato = read.ReadLine().Split(";");
                    int votos = int.Parse(candidato[1]);
                    if(dicVotos.ContainsKey(candidato[0])){
                         dicVotos[candidato[0]] += votos;
                    }else{  
                        dicVotos[candidato[0]] = votos;
                    }
                   
                    
                }
                foreach (KeyValuePair<string, int> item in dicVotos)
                {
                    System.Console.WriteLine($"Chave: {item.Key} + Valor: {item.Value}");
                }
            }
        }
    }

    public class Candidato{
        public string Nome { get; set; }
        public int Votos { get; set; }

        public Candidato(string nome, int votos){
            this.Nome = nome;
            this.Votos = votos;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Candidato)){
                return false;
            }
            var other = obj as Candidato;

            bool eIgual = false;
                if(Nome == other.Nome){
                    Votos+= Votos;
                    eIgual = true;
                }

            return eIgual;
                   
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }

        public override string ToString()
        {
            return $"Nome:{Nome}, Votos:{Votos}";
        }
    }
}
