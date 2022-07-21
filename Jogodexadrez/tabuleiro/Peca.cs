using System;

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor,Tabuleiro tab)
        {
            this.Posicao = null;
            this.Cor = cor;
            QteMovimentos = 0;
            this.Tab = tab;
        }
    }
}
