using tabuleiro;
using xadrez;
using System.Collections.Generic;

namespace Jogodexadrez
{
    internal class Tela
    {
        /* é estático porque senão eu teria que instanciar uma tela nova 
         * (ou várias telas novas conforme fosse usando), assim eu só chamo o método
         * Como faço para imprimir a posição das peças? como essa localização é privativa do tabuleiro, preciso ver uma forma
         * de dar acesso a uma peça no meu tabuleiro
         */
        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            ImprimirTabuleiro(partida.Tab);
            Console.WriteLine();
            ImprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.Turno);
            if (!partida.Terminada)
            {
                Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);
                if (partida.Xeque)
                {
                    Console.WriteLine("XEQUE!");
                }
            }
            else
            {
                Console.WriteLine("XEQUE-MATE!");
                Console.WriteLine("Vencedor: " + partida.JogadorAtual);
            }
        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas: ");
            Console.Write("Brancas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));
            Console.WriteLine();
            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write(" [");
            foreach (Peca x in conjunto)
            {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            {
                for (int i = 0; i < tab.Linhas; i++)
                {
                    Console.Write(8 - i + " ");
                    for (int j = 0; j < tab.Colunas; j++)
                    {
                        ImprimirPeca(tab.Peca(i, j));

                    }

                    Console.WriteLine();
                }
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] PosicoesPossiveis)
        //novo construtor para imprimir o tabuleiro que recebe,
        //além do tabuleiro, a matriz de booleanos de posições possíveis
        {
            ConsoleColor FundoOriginal = Console.BackgroundColor;
            ConsoleColor FundoAlterado = ConsoleColor.DarkGray; //cinza escuro quando a peça estiver marcada
            {
                for (int i = 0; i < tab.Linhas; i++)
                {
                    Console.Write(8 - i + " ");
                    for (int j = 0; j < tab.Colunas; j++)
                    {
                        if (PosicoesPossiveis[i, j] == true)
                        {
                            Console.BackgroundColor = FundoAlterado;
                        }
                        else
                        {
                            Console.BackgroundColor = FundoOriginal;
                        }
                        ImprimirPeca(tab.Peca(i, j));
                        Console.BackgroundColor = FundoOriginal;
                    }

                    Console.WriteLine();
                }
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = FundoOriginal; //Garantir que o fundo vai voltar para a cor original
        }

        public static PosicaoXadrez LerPosicaoXadrez() //Lê uma posição do xadrez que o usuário digitar
        {
            string s = Console.ReadLine();
            char coluna = s[0]; //Recebe apenas o primeiro caractere que o usuário digitou
            int linha = int.Parse(s[1] + ""); //esse espaço vazio é só para forçar a ser um string
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.Cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor; //salvei a cor cinza
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux; //voltei para a cor cinza
                }

                Console.Write(" ");


            }
        }
    }
}
