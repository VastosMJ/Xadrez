using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Campo;

namespace Xadrez.Xadrez
{
    class Torre : Peca
    {
        public Torre()
        {
        }

        public Torre(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
