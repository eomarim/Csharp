using System;

namespace ClassesAbstratas2.Entities
{
    public class PessoaFisica : Contribuinte{
        public double GastosSaude { get; set; }
        public PessoaFisica(){}
        public PessoaFisica(string nome, double rendaAnual, double gastosSaude):base(nome, rendaAnual){
          this.GastosSaude = gastosSaude;
        }

        public override double CalcularImposto()
        {
            double imposto = 0.00;
            if(base.RendaAnual < 20000.00){
                imposto = base.RendaAnual * 0.15;
            }

            else{
                imposto = base.RendaAnual * 0.25;
            }

            if(this.GastosSaude > 0){
                imposto -=  (this.GastosSaude * 0.50);
            } 

            return imposto;
        }

    }
}