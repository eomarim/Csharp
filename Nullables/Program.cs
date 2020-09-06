using System;

namespace Nullables
{
    public class Program
    {
        static void Main(string[] args)
        {
            Terminal t = new Terminal(0, "IT000320", "POS");

            Terminal? y = t;

            //p e w irai aceitar valores nulos.
            Nullable<Terminal> p = null; //Pode-se utilizar dessa forma ou 
            Terminal? w = null; //dessa forma

            Terminal? f = w ?? y;         

            Console.WriteLine("Valor de T: " + t);
            System.Console.WriteLine("Valor de Y: " + y.Value);
            Console.WriteLine("Valor de P: " + p);
            System.Console.WriteLine("Valor de W:" + w.GetValueOrDefault());

            System.Console.WriteLine("Valor de F: " + f);
            
            if(y.HasValue)
                System.Console.WriteLine("Y Possui valor");
            else
                System.Console.WriteLine("Y Nao possui valor");
            
            if(w.HasValue)
                System.Console.WriteLine("W possui valor");
            else
                System.Console.WriteLine("W nao possui valor");

            int? inteiro = null;
            int? inteiro2 = null;

            int v = inteiro2 ?? 30;
            inteiro = v;

            System.Console.WriteLine($" valor de inteiro e: {inteiro}");
            System.Console.WriteLine($"Inteiro possui valor: {inteiro.HasValue}");
            System.Console.WriteLine($"Valor de Inteiro:{inteiro.GetValueOrDefault()}");
        }
    }

    public struct Terminal {
        public int CodTerminal { get; set; }
        public string NomeTerminal { get; set; }

        public string TipoTerminal { get; set; }

        public Terminal(int codTerminal, string nomeTerminal, string tipoTerminal){
            this.CodTerminal = codTerminal;
            this.NomeTerminal = nomeTerminal;
            this.TipoTerminal = tipoTerminal;
        }
        //Nao aceita sobrecarga de construtores.
        /*public Terminal(int codTerminal, string nomeTerminal, string tipoTerminal):this(codTerminal, nomeTerminal){
            this.TipoTerminal = tipoTerminal; 
        }*/

        public override string ToString()
        {
            return $"Cod: {CodTerminal}, Terminal: {NomeTerminal}, Tipo: {TipoTerminal}";
        } 

    }
}
