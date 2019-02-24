using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Campo;

namespace Xadrez.Xadrez
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez()
        {
        }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }

        public Posicao ToPositcao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

    }
}
