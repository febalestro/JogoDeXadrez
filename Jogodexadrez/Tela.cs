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
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.Peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
