using System.Collections.Generic;
using System;

namespace IComparables2
{
    class Program
    {
        static void Main(string[] args)
        {
            var prof = new List<Professor>();
          
            prof.Add(new Professor("Moacir Marim", "Analise de Sistemas", DateTime.Parse("1985-10-11")));
            prof.Add(new Professor("Luzia Odete", "Matematica", DateTime.Parse("1985-09-11")));
            prof.Add(new Professor("Moacir Marim Junior", "Portugues", DateTime.Parse("1985-07-11")));
            prof.Add(new Professor("Eduardo Oliveira Marim", "Programacao", DateTime.Parse("1985-11-28")));

            prof.Sort();

            foreach (var item in prof)
            {
                System.Console.WriteLine(item);
            }
        }
    }

    public class Professor : IComparable<Professor>{
        public string Nome { get; set; }
        public string Materia { get; set; }
        public DateTime DataNascimento { get; set; }

        public Professor(string nome, string materia, DateTime dataNascimento){
            this.Nome = nome;
            this.Materia = materia;
            this.DataNascimento = dataNascimento;
        }

        public int CompareTo(Professor prof){
            return Nome.CompareTo(prof.Nome);
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Materia: {Materia}, Nascimento: {DataNascimento}";
        }
    }
}
