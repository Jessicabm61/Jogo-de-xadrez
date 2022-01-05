

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca (int linha, int coluna) //Retorna a peça na linha e na coluna informada
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) //Coloca uma peça 
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;

        }
    }
}
