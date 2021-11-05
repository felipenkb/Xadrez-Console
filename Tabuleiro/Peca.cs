using Xadrez_Console.tabuleiro.Enums;

namespace Xadrez_Console.tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca()
        {

        }

        public Peca(Posicao posicao, Cor cor, int qteMovimentos, Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            QteMovimentos = qteMovimentos;
            Tabuleiro = tabuleiro;
        }
    }
}
