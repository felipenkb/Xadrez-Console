using tabuleiro.Enums;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Tabuleiro Tabuleiro { get; protected set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }

        public Peca()
        {

        }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.Posicao = null;
            this.Tabuleiro = tabuleiro;
            this.Cor = cor;
            this.QteMovimentos = 0;
        }
    }
}
