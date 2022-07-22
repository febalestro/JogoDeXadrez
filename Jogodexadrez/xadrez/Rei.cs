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
    }
}
