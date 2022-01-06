using tabuleiro;

using System;
namespace chessgame
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("_ ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j)); //Imprime a peca utilizando o metodo imprimirPeca
                        Console.Write(" ");
                    }

                }
                System.Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca (Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca); //Se for branca somente imprime a peca
            }
            else {
                ConsoleColor aux = Console.ForegroundColor; //Coleta a cor atual e armazena na variável aux
                Console.ForegroundColor = ConsoleColor.Red; //Altera a cor atua para vermelho
                Console.Write(peca);    //Imprime a peca
                Console.ForegroundColor = aux; //Retorna a cor original

            }
        }
    }
}

