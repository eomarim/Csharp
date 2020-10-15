using System;

namespace EqualsGetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Renata";
            string b =  "Renata";

           // System.Console.WriteLine(a.Equals(b));

            //System.Console.WriteLine(a.GetHashCode() == b.GetHashCode());
            //System.Console.WriteLine();

            var cli1 = new Cliente(){Nome="Renata", Email="renata.sperandio@gmail.com"};
            var cli2 = new Cliente(){Nome="Renata", Email="renata.sperandio@gmail.com"};

            var cli3 = cli2;

            System.Console.WriteLine(cli3 == cli2);

            System.Console.WriteLine(cli1.Equals(cli2));

            System.Console.WriteLine(cli1.GetHashCode());
            System.Console.WriteLine(cli2.GetHashCode());
        }
    }

    public class Cliente {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Cliente)){
                throw new ArgumentException("O Objeto nao e um cliente");
            }
                var cli = obj as Cliente;

            return cli.Email.Equals(Email) && cli.Nome.Equals(Nome);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode() + Nome.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
