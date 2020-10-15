using System.Text;
using System;
using System.Collections.Generic;

namespace HashSets
{
    class Program
    {
        static void Main(string[] args)
        {
            var cursoAds = new Curso("Analise e Desenvolvimento de Sistemas");
            var cursoCdC = new Curso("Ciencia da Computacao");
            var cursoRds = new Curso("Rede de Computadores");
            var cursoRds2 = new Curso("Rede de Computadores");

            var hsCursos = new HashSet<Curso>();
            hsCursos.Add(cursoAds);
            hsCursos.Add(cursoCdC);
            hsCursos.Add(cursoRds);
            hsCursos.Add(cursoRds2);

            ListarColecoes<Curso>(hsCursos);

            var alunLuzia = new Aluno(1, "Luzia Odete");
            var alunMoacir = new Aluno(2, "Moacir Marim Junior");
            var alunMoacir2 = new Aluno(2, "Moacir Marim Junior");
            
            var hSAlunos = new HashSet<Aluno>();
            hSAlunos.Add(alunLuzia);
            hSAlunos.Add(alunMoacir);
            hSAlunos.Add(alunMoacir2);

            ListarColecoes<Aluno>(hSAlunos);

            var insEdu = new Instrutor("Eduardo Marim", hsCursos, hSAlunos);
            var insMoacir = new Instrutor("Moacir Marim");
            var insJulia = new Instrutor("Julia Resende");
            var insJulia2 = new Instrutor("Julia Resende");

            var hsInstrutor = new HashSet<Instrutor>();
            hsInstrutor.Add(insEdu);
            hsInstrutor.Add(insMoacir);
            hsInstrutor.Add(insJulia);
            hsInstrutor.Add(insJulia2);

            ListarColecoes<Instrutor>(hsInstrutor);

            System.Console.WriteLine($"Quantidade de Alunos que o Eduardo tem: {insEdu.HsAlunos.Count}");
            System.Console.WriteLine($"Cursos que o Eduardo Leciona: {insEdu.HsCursos.Count}");

            System.Console.WriteLine($"Quantidade de Instrutores que Lecionem no curso: {insEdu.HsCursos.Count}");
                        
        }

        public static void ListarColecoes<T>(IEnumerable<T> lista){
            
            foreach (T item in lista)
            {
                System.Console.WriteLine(item);
            }
        }
    }

    public class Aluno{
        public int Id { get; set; }
        public string Nome { get; set; }
        public HashSet<Curso> HsCursos { get; set; }        
        public Aluno(int id){
            this.Id = id;
        }
        public Aluno(int id, string nome):this(id){
            Nome = nome;
        }
        public Aluno(int id, string nome, HashSet<Curso> hsCursos):this(id, nome){
            HsCursos = hsCursos;
        }

        public override bool Equals(object obj)
        {
                if(!(obj is Aluno))
                    return false;

                var other = obj as Aluno;

            return 
                   Id == other.Id &&
                   Nome == other.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome);
        }

          public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("######Aluno#######");
            sb.Append(Id);
            sb.Append(Nome);
            
            if(HsCursos != null){
                  foreach (Curso item in HsCursos)
                {
                    
                    sb.Append(item.CursoName);
                }
            }

            return sb.ToString();
        }
    }

    public class Curso{
        public string CursoName { get; set; }

        public HashSet<Aluno> HsAlunos { get; set; }
        public HashSet<Instrutor> HsInstrutores { get; set; }

        public Curso(string cursoName){
            CursoName = cursoName;
        }

        public Curso(string curso, HashSet<Aluno> hsAlunos, HashSet<Instrutor> hsInstrutores):this(curso){
           
            HsAlunos = hsAlunos;
            HsInstrutores = hsInstrutores;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Curso))
                return false;

            var other = obj as Curso; 

            return 
                   CursoName == other.CursoName;
                   
        }

        public override int GetHashCode()
        {
            return CursoName.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("######Curso#######");

            sb.Append(CursoName);
            
            if(HsAlunos != null){
                  foreach (Aluno item in HsAlunos)
                {
                    sb.Append(item.Id.ToString());
                    sb.Append(item.Nome);
                }
            }
            if(HsInstrutores != null){
                foreach (Instrutor inst in HsInstrutores)
                {
                    sb.Append(inst.Nome);
                }
            }

            return sb.ToString();
        }
    }

    public class Instrutor{
        public string Nome { get; set; }
        public HashSet<Aluno> HsAlunos { get; set; }
        public HashSet<Curso> HsCursos { get; set; }

        public Instrutor(string nome){
            this.Nome = nome;
        }

        public Instrutor(string nome, HashSet<Curso> hsCursos):this(nome){
            
            this.HsCursos = hsCursos;
        }
        public Instrutor(string nome, HashSet<Curso> hsCursos, HashSet<Aluno> hsAlunos):this(nome, hsCursos){
            this.HsAlunos = hsAlunos;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Instrutor))
                return false;

                var other = obj as Instrutor;

            return
                   Nome == other.Nome;
                  
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("######Instrutor#######");

            sb.Append(Nome);
             sb.Append("######Alunos#######");
            if(HsAlunos != null){
                  foreach (Aluno item in HsAlunos)
                {
                    sb.Append(item.Id.ToString());
                    sb.Append(item.Nome);
                }
            }
            sb.Append("######Curso#######");
            if(HsCursos != null){
                foreach (Curso curso in HsCursos)
                {
                    sb.Append(curso.CursoName);
                }
            }

            return sb.ToString();
        }
    }
}
