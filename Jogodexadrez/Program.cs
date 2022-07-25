using tabuleiro;
using Jogodexadrez;
using xadrez;
try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.Terminada)
    {
        try

        {
            Console.Clear();
            Tela.ImprimirPartida(partida);

            Console.WriteLine();
            Console.Write("Origem: ");
            Posicao origem = Tela.LerPosicaoXadrez().ToPosicao(); //lê uma posição do xadrez depois transforma para uma posição de matriz
            partida.ValidarPosicaoDeOrigem(origem);


            bool[,] PosicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
            //a partir da posição de origem que o usuário digitou eu pego a peça que está lá (partida.Tab.Peca(origem))
            //e vejo os movimentos possiveis dela MovimentosPossiveis()
            //guardo na matriz PosicoesPossiveis

            Console.Clear();
            Tela.ImprimirTabuleiro(partida.Tab, PosicoesPossiveis);

            Console.WriteLine();
            Console.Write("Destino: ");
            Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeDestino(origem, destino);

            partida.RealizaJogada(origem, destino);//Depois que lê a posição, o programa executa o movimento.
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    }

}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}