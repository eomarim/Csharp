using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Linqs4
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcs = ParseTxt();

            MostrarTela<IFuncionario>(funcs, "Listando os funcionarios");
            
            //Linq Puro
            var res1 = (from y in funcs
                                    where y.Salario > 20000.00
                                    orderby y.Email
                                    select y

            );
            MostrarTela<IFuncionario>(res1, "1 forma: Funcionarios que tem o salario maior que 20.000 ordenado por email");

            //Lambda
            var res2 = funcs.
                            Where(p => p.Salario > 20000.00).
                            OrderBy(p => p.Email);

            MostrarTela<IFuncionario>(res2, "2 forma: Funcionarios que tem o salario maior que 20.000 ordenado por email");

            //Funcao
            var res3 = funcs.Where(SalarioSuperior20Mil).
                                    OrderBy(OrdenadoEmail);

            MostrarTela<IFuncionario>(res3, "3 forma: Funcionarios que tem o salario maior que 20.000 ordenado por email");

            //Delegate
            Func<IFuncionario, bool> func1 = SalarioSuperior20Mil;
            Func<IFuncionario, string> func2 = OrdenadoEmail;
            var res4 = funcs.Where(func1).OrderBy(func2);
            MostrarTela<IFuncionario>(res4, "4 forma: Funcionarios que tem o salario maior que 20.000 ordenado por email");

            var res5 = (from y in funcs
                            where y.Salario > 20000.00
                            orderby y.Nome
                            select new {y.Nome, y.Email}
            );
            MostrarTela<object>(res5, "5 forma: Funcionarios que tem o salario maior que 20.000 ordenado por email, mostrando somente Nome e email");

            //Linq Puro
            var res6 = (
                        from y in funcs
                                    where y.Nome.ToUpper().StartsWith("M")
                                    select y.Salario
            ).DefaultIfEmpty(0.00).Sum();

            System.Console.WriteLine($"1 Forma: A Soma de todos os salarios dos Funcionarios que o nome comeca com a letra M e:{res6}");
            //Lambda
            var res7 = funcs.Where(f => f.Nome.ToUpper().StartsWith("M")).
                             Select(f => f.Salario).
                             DefaultIfEmpty(0.00).
                             Sum();

            System.Console.WriteLine($"2 Forma: A Soma de todos os salarios dos Funcionarios que o nome comeca com a letra M e:{res7}");
            //Passando Funcao
            var res8 = funcs.Where(FuncIniciaLetraM).
                                Select(RetornaSalario).DefaultIfEmpty(0.00).Sum();

            System.Console.WriteLine($"3 Forma: A Soma de todos os salarios dos Funcionarios que o nome comeca com a letra M e:{res8}");

            //Usando Delegate
            Func<IFuncionario, bool> funNome = FuncIniciaLetraM;
            Func<IFuncionario, double> funSalario = RetornaSalario;
            var res9 = funcs.Where(funNome).
                            Select(funSalario).Sum();
            
            System.Console.WriteLine($"4 Forma: A Soma de todos os salarios dos Funcionarios que o nome comeca com a letra M e:{res9}");

        }
        
        public static double RetornaSalario(IFuncionario obj) => obj.Salario;
        public static bool FuncIniciaLetraM(IFuncionario obj) => obj.Nome.StartsWith("M");
        public static string OrdenadoEmail(IFuncionario obj) => obj.Email;
        public static bool SalarioSuperior20Mil(IFuncionario obj) => obj.Salario > 20000.00; 
        public static void MostrarTela<T>(IEnumerable<T> lst, string msg){
            System.Console.WriteLine(msg);
            foreach (var item in lst)
            {
                System.Console.WriteLine(item);
            }
        }

        public static List<IFuncionario> ParseTxt(){
            var lstFunc = new List<IFuncionario>();
            using(StreamReader str = File.OpenText(@"/Users/eduardomarim/Programacao/CSharp/Linqs4/funcionario.txt")){
                while(!(str.EndOfStream)){
                    string[] obj = str.ReadLine().Split(new char[]{',', ';'});
                    lstFunc.Add(new Funcionario(obj[0], obj[1], double.Parse(obj[2])));
                }
            }
            return lstFunc;
        }
    }

    public interface IFuncionario
    {
        string Nome { get; set; }
        string Email { get; set; }
        double Salario { get; set; }

        int CompareTo(object obj);
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }

    public class Funcionario : IComparable, IFuncionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Funcionario;

            return other.Nome.Equals(Nome);
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode() + Email.GetHashCode();
        }

        public override string ToString()
        {
            return $"Nome:{Nome}, Email:{Email}, Salario:{Salario}";
        }

        public int CompareTo(object obj)
        {
            var other = obj as Funcionario;

            return other.Nome.CompareTo(Nome);
        }
    }
}
