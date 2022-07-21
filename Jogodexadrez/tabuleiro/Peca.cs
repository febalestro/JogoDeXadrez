﻿

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor,Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            QteMovimentos = 0;
            this.tab = tab;
        }
    }
}