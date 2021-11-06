using System;
using Tabuleiro;
using Tabuleiro.Enums;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  try
             {
                 TabuleiroClasse tab = new TabuleiroClasse(8, 8);

                 tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                 tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                 tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                 Tela.ImprimirTabuleiro(tab);
             }
             catch(TabuleiroException e)
             {
                 Console.WriteLine(e.Message);
             }

             Console.WriteLine(); */

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos.ToPosicao());
        }
    }
}
