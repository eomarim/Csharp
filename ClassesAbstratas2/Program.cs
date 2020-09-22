using System.Security;
using System.Collections.Generic;
using System;
using ClassesAbstratas2.Entities;

namespace ClassesAbstratas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contribuinte ctr = new PessoaFisica("Eduardo Marim", 10000.00, 10.00);

            Contribuinte ctrPj = new PessoaJuridica("Moacir", 10000.00, 11);
            
             System.Console.WriteLine($"Contribuinte: {ctr.Nome}, " 
             + $"cujo a renda anual foi de:{ctr.RendaAnual.ToString("F2")}, "
            + $"pagara de imposto:{ctr.CalcularImposto().ToString("F2")}");

            System.Console.WriteLine($"Contribuinte: {ctrPj.Nome}, " 
             + $"cujo a renda anual foi de:{ctrPj.RendaAnual.ToString("F2")}, "
            + $"pagara de imposto:{ctrPj.CalcularImposto().ToString("F2")}");

            List<Contribuinte> lstContr = new List<Contribuinte>();

            lstContr.Add(new PessoaFisica("Renata", 100000.00, 1000));
            lstContr.Add(new PessoaFisica("Eduardo", 100000.00, 1000));
            lstContr.Add(new PessoaJuridica("Moacir", 200000.00, 20));
            lstContr.Add(new PessoaJuridica("Dete", 300000.00, 30));

            double totalImpostos = 0.00;
            PessoaFisica p = null;
            PessoaJuridica j = null;
            foreach (Contribuinte item in lstContr)
            {
                if(item is PessoaJuridica){
                    j = item as PessoaJuridica;
                    System.Console.WriteLine($"Numero de Funcionarios:{j.NumeroFuncionarios}");
                }
                else{
                    p = item as PessoaFisica;
                    System.Console.WriteLine($"Total com gastos Medicos:{p.GastosSaude}");
                }
                totalImpostos += item.CalcularImposto();
            }

            System.Console.WriteLine($"O total de impostos a serem pagos pelos" 
            + $"contribuentes e de:{totalImpostos.ToString("F2")}");
        }
    }
}
