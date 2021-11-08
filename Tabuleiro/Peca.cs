﻿using Tabuleiro.Enums;

namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public TabuleiroClasse Tab { get; protected set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }

        public Peca()
        {
        }

        public Peca(TabuleiroClasse tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QteMovimentos = 0;
        }
        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }
        public abstract bool[,] MovimentosPossiveis();
        
    }
}
