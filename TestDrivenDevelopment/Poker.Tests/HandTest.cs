
namespace Poker.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    [TestClass]
    public class HandTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowsExceptionWhenListOfCardsIsNull()
        {
            IList<ICard> cards = null;
            var hand = new Hand(cards);
        }

        [TestMethod]
        public void ReturnsCorrectlyToString()
        {
            var card = new List<ICard> {
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Diamonds)
        };
            var hand = new Hand(card);
            var result = "Ace of Hearts + Five of Diamonds";
            Assert.AreEqual(result, hand.ToString());
        }

    }
}
