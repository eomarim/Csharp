using System;
namespace WebSalesMvc.Models
{
    public class Venda
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public double Valor { get; set; }

        public Status StatusVenda { get; set; }

        public Vendedor VendedorVenda { get; set; }

        public Venda() { }

        public Venda(int id, DateTime data, double valor, Status statusVenda)
        {
            Id = id;
            Data = data;
            Valor = valor;
            StatusVenda = statusVenda;
        }




    }
}
