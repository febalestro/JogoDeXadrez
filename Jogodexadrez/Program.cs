using tabuleiro;
using Jogodexadrez;
using xadrez;
try
{
    Tabuleiro tab = new Tabuleiro(8, 8);

    tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
   // tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
   // tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 2));

    tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(3, 5));
    tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(3, 6));
    tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(3, 7));

    Tela.ImprimirTabuleiro(tab);
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}