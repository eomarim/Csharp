using System;
using System.Collections.Generic;
using System.Linq;

namespace WebSalesMvc.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome{ get; set; }

        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento() { }

               public Departamento(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public void AddVendedor(Vendedor vend) => Vendedores.Add(vend);
        

        public double TotalVendas(DateTime dataInicial, DateTime datafinal)
        {
            //COmplexo 
            var x = Vendedores.
                Where(y => y.Vendas.
                Where(z => z.Data >= dataInicial && z.Data <= datafinal).
                Count() > 0).
                Select(e => e.Vendas.
                Select(r => r.Valor).
                DefaultIfEmpty(0.00)).
                Sum(j => j.Sum());

            //Chamando o proprio metodo da classe total vendas
            var w = Vendedores.Sum(o => o.TotalVendas(dataInicial, datafinal));

            return w;
               
        }
    }
}
