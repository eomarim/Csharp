using System;
using Tabuleiro;

namespace Tabuleiro.Xadrez
{
    public class PosicaoXadrez{

        public char Coluna { get; set; }
        public int Linha { get; set; }
        public PosicaoXadrez(char Coluna, int linha){
            this.Coluna = Coluna;
            this.Linha = linha;

        }
        public override string ToString()
        {
            return "" + Coluna + Linha;
        }

        public Posicao ToPosicao(){
            return new Posicao(8 - Linha, Coluna - 'a');
        }
    }
}