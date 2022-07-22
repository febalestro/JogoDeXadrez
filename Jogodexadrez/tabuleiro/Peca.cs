
//Uma peça tem uma posição, tem uma cor, se move e está em um tabuleiro

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; } //quantos movimentos a peça já fez
        public Tabuleiro Tab { get; protected set; } //tabuleiro onde a peça está

        public Peca(Cor cor,Tabuleiro tab)
        {
            Posicao = null;
            this.Cor = cor;
            QteMovimentos = 0; //inicia com zero, por isso não é um argumento do construtor
            this.Tab = tab;
        }
    }
}
