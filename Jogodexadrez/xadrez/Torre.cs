

using tabuleiro;

namespace xadrez
{
    internal class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }
        public override string ToString()
        {
            return "T";
        }

        //Precisei criar esse método para complementar o de baixo. Pois, a minha peça só pode se mover para onde não tiver outras peças minhas.
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            /*mesma coisa que linha de código  abaixo:
             * if (p == null || p.Cor != this.Cor)
            {
                return true;
            }
            else
            {
                return false;
            }*/
            return p == null || p.Cor != this.Cor; //Testa se não tem peça ou se não tem peça da mesma cor do rei. Aí poderá mover.
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas]; //crio uma matriz temporária
            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))//enquanto eu não chegar até o final do tabuleiro e enquanto o POdeMover for válido
            { 
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {  //se tab.peca for diferente de nulo (ou seja, tem uma peça lá) e se a cor é diferente, ou seja, é uma peça adversária eu quebro o while
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }

            //abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }

            //direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }

            //esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }

            return mat;
        }
    }
}
