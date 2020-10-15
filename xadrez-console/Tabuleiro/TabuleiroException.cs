using System;

namespace Tabuleiro
{
    public class TabuleiroException : Exception{
        public TabuleiroException(string mensagem):base(mensagem){}
    }
}