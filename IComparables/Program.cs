using System.Collections.Generic;
using System.IO;
using System;

namespace IComparables
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lstFunc = LerTxt();
            lstFunc.Sort();

            foreach (Funcionario item in lstFunc)
            {
                System.Console.WriteLine($"Nome:{item.Nome}, Salario: {item.Salario}");
            }
        }

        public static List<Funcionario> LerTxt(){
            List<Funcionario> func = new List<Funcionario>();

            try
            {
                    using(StreamReader sr = File.OpenText(@"/Users/eduardomarim/Programacao/CSharp/IComparables/in.txt")){
                    while(!sr.EndOfStream){
                       string temp = sr.ReadLine();
                    
                      //  System.Console.WriteLine(temp);
                    
                        string[] funcTemp = temp.Split(";");

                        func.Add(new Funcionario(){
                            Nome = funcTemp[0],
                            Salario = double.Parse(funcTemp[1])
                        });  
                    }
                }
               
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            
            return func;
        }

        
    }
    public class Funcionario : IComparable {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public int CompareTo(object obj){
            if(!(obj is Funcionario))
                throw new ArgumentException("Obj nao e um funcionario!!");
        
                //Funcionario func = (Funcionario) obj;
                Funcionario func = obj as Funcionario;

                //return Nome.CompareTo(func.Nome);

                return Salario.CompareTo(func.Salario);
            }
    }
}
