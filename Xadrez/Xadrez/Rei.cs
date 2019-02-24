﻿using Xadrez.Campo;

namespace Xadrez.Xadrez
{
    class Rei : Peca
    {
        public Rei()
        {
        }

        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != this.Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //NE
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna +1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //Se
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //SO
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //NO
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;
            return mat;
        }

    }
}
