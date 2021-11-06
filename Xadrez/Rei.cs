using Tabuleiro;
using Tabuleiro.Enums;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(TabuleiroClasse tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
