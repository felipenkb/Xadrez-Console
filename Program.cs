﻿using System;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.tabuleiro.Enums;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);
        }
    }
}
