using System;
using Tabuleiro;

namespace Tabuleiro.Xadrez
{
    public class Rei : Peca{
        public Rei(Tabuleiro tab, Cor cor):base(tab, cor){

        }
        public override string ToString()
        {
            return "R";
        }
    }
}