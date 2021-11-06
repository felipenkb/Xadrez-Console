using Tabuleiro.Enums;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public TabuleiroClasse Tabuleiro { get; protected set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }

        public Peca()
        {

        }

        public Peca(TabuleiroClasse tabuleiro, Cor cor)
        {
            Posicao = null;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QteMovimentos = 0;
        }
    }
}
