
namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas; //matriz de peças do jogo de xadrez

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas]; //recebe uma nova matriz de peças que tem n linhas e n colunas
        }
        //como essa localização é privativa do tabuleiro, esse método acesso a uma peça no meu tabuleiro.
        //retorna uma peça na linha e na coluna informadas

        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca Peca(Posicao pos)//sobrecarga do método peça, só que ao invés de receber uma linha e uma coluna, ele recebe uma posição
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);// coloco isso antes pq se a posição for inválida eu corto o método e lanço exceção
            return Peca(pos) != null;
        }

        public void ColocarPeca(Peca p, Posicao pos)// ir na matriz peças, na posição pos.linha e pos.coluna e recebe a peça p
        {
            if (ExistePeca(pos)) {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos; //a posição da minha peça p é essa que acabei de colocar
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if (Peca(pos) == null)
            {
                return null;
            }
            Peca aux = Peca(pos); //se tem peça na dada posição, crio uma variável auxiliar pra receber a peça que está naposição informada
            aux.Posicao = null; //agora a posição dessa peça é null
            Pecas[pos.Linha, pos.Coluna] = null; // vou no tabuleiro "Pecas" e colocar nulo na posição i,j informada
            return aux; //retorno a peça que guardei na posição auxiliar
        }
            public bool PosicaoValida(Posicao pos)
            {
                if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
                {
                    return false;
                }
                return true;
            }

            public void ValidarPosicao(Posicao pos) //caso a posição não seja válida, lança uma exceção personalizada
            {
                
            if (!PosicaoValida(pos))
                {
                    throw new TabuleiroException("Posição inválida!");
                }
            }
        }
    }

