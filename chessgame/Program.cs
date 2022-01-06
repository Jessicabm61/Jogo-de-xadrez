using System;
using tabuleiro;
using xadrez;

namespace chessgame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 0));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }

        }
    }
}
