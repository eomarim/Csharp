using System;
namespace Tabuleiro
{
    public class Peca {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }

        public int QtdeMovimento { get; protected set; }

        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(){}

        public Peca(Tabuleiro tabuleiro, Cor cor):this(){
            this.Posicao = null;
            this.Tabuleiro = tabuleiro;
            this.Cor = cor;
            this.QtdeMovimento = 0;
        }
        public void IncrementarQtdeMovimentos(){
            QtdeMovimento++;
        }

    }
}