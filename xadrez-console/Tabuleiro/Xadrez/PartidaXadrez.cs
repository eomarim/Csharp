using System;
using Tabuleiro;

namespace Tabuleiro.PartidaXadrez
{
    public class PartidaXadrez{
        public Tabuleiro Tabuleiro { get; set; }
        public int Turno { get; set; }
        public Cor JogadorAtual { get; set; }
        public PartidaXadrez(){
            Tabuleiro = new Tabuleiro(8,8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino){
            Peca p = Tabuleiro.RetirarPeca(origem);
            p.IncrementarQtdeMovimentos();
            Peca pecaCapturada = Tabuleiro.RetirarPeca(destino);
            Tabuleiro.ColocarPeca(p, destino);

            
        }


    }
}