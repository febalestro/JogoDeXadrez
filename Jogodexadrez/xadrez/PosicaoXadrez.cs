using tabuleiro;

namespace xadrez
{
    internal class PosicaoXadrez //adequando as posições da matriz à um tabuleiro de xadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        //método para converter a posição do xadrez para posições da matriz
        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a'); //internamente, a é um número, então b - a dá 1.
        }


        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
