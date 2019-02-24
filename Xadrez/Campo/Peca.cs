﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.Campo
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca()
        {
        }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            QteMovimentos = 0;
            Tab = tab;
        }
        public void IcrementarQteMovimento()
        {
            QteMovimentos++;
        }

    }
}
