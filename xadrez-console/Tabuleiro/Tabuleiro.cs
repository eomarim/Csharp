using System;

namespace Tabuleiro
{
    public class Tabuleiro {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] Pecas;

        public Tabuleiro(){

        }

        public Tabuleiro(int linhas, int colunas):this(){
            this.Linhas = linhas;
            this.Colunas = colunas;
            this.Pecas = new Peca[linhas, colunas];
        }


    }
}