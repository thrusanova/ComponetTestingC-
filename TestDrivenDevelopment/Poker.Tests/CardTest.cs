using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void ShouldCompareTwoEqualCardsCorrectly()
        {
            var firstCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            var secondCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            Assert.IsFalse(firstCard.Equals(secondCard));
        }

        [TestMethod]
        public void ShouldCompareTwoDifferentCarsdCorectlY()
        {
            var firstCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            var secondCard = new Card(CardFace.Eight, CardSuit.Diamonds);
            Assert.IsFalse(firstCard.Equals(secondCard));
        }

        [TestMethod]
        public void ShouldReturnToStringCorrectly()
        {
            var card = new Card(CardFace.Eight, CardSuit.Hearts);
            var cardToStr = "Eight of Hearts";
            Assert.AreEqual(cardToStr, card.ToString());
        }
    }
}
