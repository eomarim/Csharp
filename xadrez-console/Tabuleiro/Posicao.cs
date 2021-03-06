using System;

namespace Tabuleiro
{
    public class Posicao {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(){}
        public Posicao(int linha, int coluna):this(){
            this.Linha = linha;
            this.Coluna = coluna;
        }
        public override string ToString()
        {
            return $"Posicao: {Linha}, {Coluna}";
        }
    }
}