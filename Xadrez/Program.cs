﻿using System;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);

            Console.WriteLine();

            
        }
    }
}
