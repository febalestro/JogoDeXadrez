using tabuleiro;
using Jogodexadrez;
using xadrez;
try
{
    Tabuleiro tab = new Tabuleiro(8, 8);

    tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 9));
    tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 2));

    Console.WriteLine("truta");
    Console.WriteLine(tab.Peca(0, 0));

    Tela.ImprimirTabuleiro(tab);
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}