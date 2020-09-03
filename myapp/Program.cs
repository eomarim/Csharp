using System;

namespace myapp
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Informe o Codigo do Veiculo:");
            int codigo = int.Parse(Console.ReadLine());

            System.Console.Write("Informe o Fabricante do Veiculo:");
            string fabricante = Console.ReadLine();
            
            System.Console.Write("Informe o Modelo do Veiculo:");
            string modelo = Console.ReadLine();

            var x = new Carro(codigo, fabricante, modelo);
            Console.WriteLine(x);
        }
    }

    public struct Carro{
        public int CodCarro { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }

        public Carro(int codigo, string fabricante, string modelo){
            this.CodCarro = codigo;
            this.Fabricante = fabricante;
            this.Modelo = modelo;
        }

        public override string ToString(){
            return $"Codigo:{CodCarro}, Fabricante:{this.Fabricante}, Modelo:{Modelo}";
        }
    }

}
