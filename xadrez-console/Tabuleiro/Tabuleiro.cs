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

        public Peca Peca(int linha, int coluna){
            return Pecas[linha, coluna];
        }



        public bool PosicaoValida(Posicao pos){
            if(pos.Linha < 0 || pos.Linha >=Linhas || pos.Coluna < 0 || pos.Coluna >=Colunas){
                return false;
            }
            return true;
        }
        public void ValidarPosicao(Posicao pos){
            if(!PosicaoValida(pos)){
                throw new TabuleiroException("Tamanho incorreto para o Tabuleiro");
            }
        }

        public bool ExistePeca(Posicao pos){
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }
        public void ColocarPeca(Peca p, Posicao pos){
            if(ExistePeca(pos))
                throw new TabuleiroException("Ja existe uma peca nessa posicao");

            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
        public Peca Peca(Posicao pos){
            return Pecas[pos.Linha, pos.Coluna];
        }
        public void RetirarPeca(Posicao pos){
            if(Peca(pos) == null){
                return null;
            }
            Peca aux = Peca(pos);
            aux.Posicao = null;
            Pecas[pos.Linha] = null;
            Pecas[pos.Coluna] = null;

            return aux;
        }

    }
}