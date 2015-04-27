using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex3
{
    public class Deck
    {
        private static List<Card> deckOfCards = new List<Card>();

        private static void Main()
        {
            CreateDeckOfCards();

            DisplayTheDeckOfCards();

            deckOfCards = Shuffle();

            DisplayTheDeckOfCards();
        }

        public static void CreateDeckOfCards()
        {
            for (int i = 1; i <= 14; i++)
            {
                deckOfCards.Add(new Card(Suit.Club, i));
                deckOfCards.Add(new Card(Suit.Daimond, i));
                deckOfCards.Add(new Card(Suit.Heart, i));
                deckOfCards.Add(new Card(Suit.Spades, i));
            }
        }

        public static List<Card> Shuffle()
        {
            var randList=new List<Card>();
            var random = new Random();

            while (deckOfCards.Count > 0)
            {
                var randIndex = random.Next(0, deckOfCards.Count);
                randList.Add(deckOfCards[randIndex]);
                deckOfCards.RemoveAt(randIndex);
            }

            return randList;
        }

        private static void DisplayTheDeckOfCards()
        {
            foreach (var card in deckOfCards)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
