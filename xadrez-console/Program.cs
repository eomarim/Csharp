using System;
using Tab = Tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tela.ImprimirTabuleiro(new Tab.Tabuleiro(8, 8));
        }

        
    }
}
