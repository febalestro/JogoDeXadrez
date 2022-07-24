using tabuleiro;
using Jogodexadrez;
using xadrez;
try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.Terminada)
    {
        Console.Clear ();
        Tela.ImprimirTabuleiro(partida.Tab);

        Console.WriteLine();
        Console.WriteLine("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao(); //lê uma posição do xadrez depois transforma para uma posição de matriz
        Console.WriteLine("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

        partida.ExecutaMovimento(origem, destino);//Depois que lê a posição, o programa executa o movimento.
    }

   
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}