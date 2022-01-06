

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
        
        public Peca peca (Posicao pos) //[SOBRECARGA - outro metodo para obter a posicao da matriz]retorna a peça na linha e na cooluna mas nesse caso ele recebe uma posicao pos e retorna a matriz
        {
            return pecas[pos.linha, pos.coluna];
        }
        public void colocarPeca(Peca p, Posicao pos) //Coloca uma peça 
        {
            if (existePeca(pos)) //Se esse método retornar true lança a excecão 
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public bool existePeca (Posicao pos) //Método que verifica se existe peça na posicao escolhida caso exista retorna true
        {
            validarPosicao(pos); //chama o metodo validarPosisao, caso esse método retorne false o programa é cortado e é apresentado na tela a mensagem da Exception
            return peca(pos) != null;
        }

        public bool posicaoValida(Posicao pos) //testa se a posicao é válida
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false; //return corta o metodo
            }
            return true;
        }

        public void validarPosicao(Posicao pos) //lança a exceção caso o método posicaoValida retorne false
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!"); //caso caia nessa exceção é cortado o método e lançado a mensagem na classe TabuleiroException
            }
        }
    }
}
