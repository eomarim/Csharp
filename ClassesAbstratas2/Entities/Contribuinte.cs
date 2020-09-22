using System;

namespace ClassesAbstratas2.Entities
{
    public abstract class Contribuinte{
        public string Nome { get; set; }
        public double RendaAnual{get; set;}

        public Contribuinte(){}
        public Contribuinte(string nome, double rendaAnual){
            this.Nome = nome;
            this.RendaAnual = rendaAnual;
        }
        public abstract double CalcularImposto();

    }
}