using tabuleiro;

namespace Jogodexadrez
{
    internal class Tela
    {
        /* é estático porque senão eu teria que instanciar uma tela nova 
         * (ou várias telas novas conforme fosse usando), assim eu só chamo o método
         * Como faço para imprimir a posição das peças? como essa localização é privativa do tabuleiro, preciso ver uma forma
         * de dar acesso a uma peça no meu tabuleiro
         */
        public static void ImprimirTabuleiro(Tabuleiro tab) // 
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.Peca(i,j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void ImprimirPeca(Peca peca)
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
        }
    }
}
