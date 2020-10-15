using System;
using Tab = Tabuleiro;
using Tabuleiro.Xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tab.Tabuleiro tabu = new Tab.Tabuleiro(8,8);
                
                Rei rei = new Rei( tabu, Tab.Cor.Amarela);
                Torre torre = new Torre( tabu, Tab.Cor.Amarela);

                tabu.ColocarPeca(rei, new Tab.Posicao(0,0));
                tabu.ColocarPeca(torre, new Tab.Posicao(7,2));

                Tela.ImprimirTabuleiro(tabu); 

                PosicaoXadrez pos = new PosicaoXadrez('h', 1);
                System.Console.WriteLine(pos);

                Console.WriteLine(pos.ToPosicao());
            }
            catch (Tabuleiro.TabuleiroException msg)
            {
                
                System.Console.WriteLine(msg);
            }

         

            
        }

        
    }
}
