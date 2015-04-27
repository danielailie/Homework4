using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex3;

namespace Ex3Test
{
    [TestClass]
    public class DeckTest
    {
        [TestMethod]
        public void After_The_Shuffle_The_Deck_Is_Suhffle()
        {
            var deckOfCards=new List<Card>();
            Deck.CreateDeckOfCards();

            var afterShuffle = Deck.Shuffle();
            var afterSecondShuffle = Deck.Shuffle();

            Assert.AreNotEqual(deckOfCards,afterShuffle);
            Assert.AreNotEqual(afterShuffle,afterSecondShuffle);
        }
    }
}
