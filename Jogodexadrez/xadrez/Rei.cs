using tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab) //quando crio um rei ele simplesmente passa essa informação para a superclasse peça
        {

        }
        public override string ToString()
        {
            return "R";
        }

        //Precisei criar esse método para complementar o de baixo. Pois, a minha peça só pode se mover para onde não tiver outras peças minhas.
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != this.Cor; //Testa se não tem peça ou se não tem peça da mesma cor do rei. Aí poderá mover.
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas]; //crio uma matriz temporária
            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) //se a posição é válida e se posso mover para aquela posição (testes), então a matriz recebe o valor true
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {  
                mat[pos.Linha, pos.Coluna] = true;
            }

            //direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        } 
    }
}
