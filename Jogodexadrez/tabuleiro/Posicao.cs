//Dizer em qual linha e em qual coluna uma peça está

namespace tabuleiro
{
    internal class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        public void DefinirValores(int linha, int coluna) //método criado para auxiliar a criar as movimentações personalizadas de cada peça
        {
           Linha = linha;
           Coluna = coluna;
        }

        public override string ToString()
        {
            return Linha
                + ", "
                + Coluna;
        }
    }
}
