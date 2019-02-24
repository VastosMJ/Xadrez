using Xadrez.Campo;

namespace Xadrez.Xadrez
{
    class Rei : Peca
    {
        public Rei()
        {
        }

        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }
        public override string ToString()
        {
            return "R";
        }

    }
}
