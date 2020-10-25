using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSalesMvc.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome{ get; set; }

        public Departamento() { }
        public Departamento(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
    }
}
