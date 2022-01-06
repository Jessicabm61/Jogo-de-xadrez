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
                PartidadeXadrez partida = new PartidadeXadrez(); //Cria uma partida de xadrez
                Tela.imprimirTabuleiro(partida.tab);

               
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }

        }
    }
}
