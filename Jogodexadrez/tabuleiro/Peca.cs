
//Uma peça tem uma posição, tem uma cor, se move e está em um tabuleiro

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; } //quantos movimentos a peça já fez
        public Tabuleiro Tab { get; protected set; } //tabuleiro onde a peça está

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            this.Cor = cor;
            QteMovimentos = 0; //inicia com zero, por isso não é um argumento do construtor
            this.Tab = tab;
        }

        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }

        public void DecrementarQteMovimentos()
        {
            QteMovimentos--;
        }

        //Testar se na matriz de booleanos existe algum valor possível
        //Ou se ela está bloqueada de movimento
        public bool ExistemMovimentosPossiveis() 
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i,j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }


        //Retorna um booleano porque quero marcar na matriz onde o movimento é possível e onde não é
        //Método abstrato porque depende da peça, então não posso implantar nessa classe
        public abstract bool[,] MovimentosPossiveis(); 
        
        
    }
}
