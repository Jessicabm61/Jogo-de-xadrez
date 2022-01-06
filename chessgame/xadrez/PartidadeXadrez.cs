using System;
using tabuleiro;


namespace xadrez
{
    class PartidadeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;

        public PartidadeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino) 
        {
            Peca p = tab.retirarPeca(origem); //Retira a peca da posicao origem e armazena na variável p
            p.incrementaQteMovimento(); //Método que conta a quantidade de movimentos
            Peca pecaCapturada = tab.retirarPeca(destino); //armazena a peça da posicao destino na variável pecaCapturada
            tab.colocarPeca(p, destino); //coloca a peça que estava na origem na posicao destino
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 1).toPosicao()); //(peca,posicao)
        }
    }
}
