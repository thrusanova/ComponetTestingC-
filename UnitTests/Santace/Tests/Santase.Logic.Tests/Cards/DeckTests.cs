namespace Santase.Logic.Tests.Cards
{
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;

    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void TrumpCardShouldBeNotNull()
        {
            var deck = new Deck();
            Assert.IsNotNull(deck.TrumpCard);
        }

        [Test] 
       public void TwoEqualCardsAreTheSame()
       { 
            var first = new Card(CardSuit.Heart, CardType.Queen); 
            var second = new Card(CardSuit.Heart, CardType.Queen); 
            Assert.AreEqual(first, second); 
         }
        [Test]
        public void ExpectTheTrumpCardToBeTakenLast()
        { 
            var deck = new Deck(); 
             var trumpCard = deck.TrumpCard; 
             Card lastCard = deck.GetNextCard(); 

            while (deck.CardsLeft > 0) 
            { 
                 lastCard = deck.GetNextCard(); 
            } 
          Assert.AreSame(trumpCard, lastCard); 
       }
        [Test]
        public void ChangeTrumpCardShouldWorkProperly()
        {
            IDeck deck = new Deck();
            var card = new Card(CardSuit.Spade, CardType.Nine);
            deck.ChangeTrumpCard(card);
            var trumpCard = deck.TrumpCard;
            Assert.AreEqual(card, trumpCard);
        }


    }   
}
