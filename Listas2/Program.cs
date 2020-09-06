using System.Collections.Generic;
using System;

namespace Listas2
{
    public class Program
    {
        private const double PercentualIncrease = 10;

        public static void Main(string[] args)
        {
            System.Console.Write("Informe Quantos Funcionarios Serao Cadastrados: ");
            int qtdeFuncionarios = int.Parse(Console.ReadLine());

            var employees =  new List<Employe>();
            for (int i = 0; i < qtdeFuncionarios; i++)
            {   
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employe(
                    id,
                    name,
                    salary));

            }

            foreach (Employe item in employees)
            {
                System.Console.WriteLine(item);
            }
            System.Console.Write("Informe o id do Funcionario que tera seu salario reajustado: ");
            int idFuncionarioAumentaSalario = int.Parse(Console.ReadLine());

            Employe emp = employees.Find(x => x.Id == idFuncionarioAumentaSalario);

            if(emp != null){
                System.Console.Write("Informe o percentual de reajuste:");
                double percentualIncrease = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentualIncrease);    
            }
                
            else
                System.Console.WriteLine("Employee Not Found!");

            foreach (Employe item in employees)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
