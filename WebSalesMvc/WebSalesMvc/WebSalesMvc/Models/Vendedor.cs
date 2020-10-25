using System;
using System.Collections.Generic;
using System.Linq;

namespace WebSalesMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento DepartamentoVendedor { get; set; }
        public ICollection<Venda> Vendas { get; set; } = new List<Venda>();

        public Vendedor() {}

        public Vendedor(int id, string nome, string email, DateTime nascimento, double salario)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
            SalarioBase = salario;
        }

        public void AddVenda(Venda venda) => Vendas.Add(venda);
        
        public void RemoverVenda(Venda venda) => Vendas.Remove(venda);


        public double TotalVendas(DateTime dataInicial, DateTime dataFinal) {

            //1 forma usando linq puro
            var x = (from y in Vendas
                     where y.Data >= dataInicial && y.Data <= dataFinal
                     select y.Valor
                     ).DefaultIfEmpty(0.00).Sum();
            
            //2 forma usando lambda
            var z = (Vendas.
                    Where(y => y.Data >= dataInicial && y.Data <= dataFinal).
                    Select(y => y.Valor)).DefaultIfEmpty(0.00).Sum();

            return z;
        }
    }
}
