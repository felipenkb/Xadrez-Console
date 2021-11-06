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
            this.Posicao = null;
            this.Tabuleiro = tabuleiro;
            this.Cor = cor;
            this.QteMovimentos = 0;
        }
    }
}
