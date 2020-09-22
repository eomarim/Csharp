using System;

namespace ClassesAbstratas2.Entities
{
    public class PessoaJuridica : Contribuinte{
        public int NumeroFuncionarios { get; set; }
        public PessoaJuridica(){}
        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios):base(nome, rendaAnual){
          this.NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalcularImposto()
        {
            double imposto = 0.00;

                if(this.NumeroFuncionarios > 10){
                    imposto = base.RendaAnual * 0.14;
                }else{
                    imposto = base.RendaAnual * 0.16;
                }
            return imposto;
        }

    }
}