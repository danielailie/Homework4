using System;

namespace Ex3
{
    public class Card
    {
        private readonly Suit suit;
        private readonly int rank;
        public Card(Suit suit,int rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} ", rank, suit);
        }
    }
}
