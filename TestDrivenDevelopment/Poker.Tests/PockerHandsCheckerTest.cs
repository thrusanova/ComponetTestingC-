using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Tests

{ 
    [TestClass]
    public class PockerHandsCheckerTest
   {
        [TestMethod]
        public void IsValidHandShouldValidCombination()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
               {
                   new Card(CardFace.Queen, CardSuit.Spades),
                   new Card(CardFace.Seven, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Hearts),
                   new Card(CardFace.King, CardSuit.Spades),
                   new Card(CardFace.King, CardSuit.Diamonds)
             };
            var hand = new Hand(cards);
            checker.IsValidHand(hand);
        }

        [TestMethod]
        public void IsHighCardShoudReturnTrue()
       {

            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
               {
                   new Card(CardFace.Queen, CardSuit.Spades),
                   new Card(CardFace.Seven, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Hearts),
                   new Card(CardFace.King, CardSuit.Spades),
                   new Card(CardFace.King, CardSuit.Diamonds)
             };
            var hand = new Hand(cards);
            Assert.IsFalse(checker.IsHighCard(hand));
        }
    

    [TestMethod]
    public void IsReturnTrueOnePair()
    {
        var checker = new PokerHandsChecker();
        var cards = new List<ICard>
               {
                   new Card(CardFace.Queen, CardSuit.Spades),
                   new Card(CardFace.Seven, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Hearts),
                   new Card(CardFace.King, CardSuit.Diamonds),
                   new Card(CardFace.King, CardSuit.Diamonds)
             };
        var hand = new Hand(cards);
        Assert.IsTrue(checker.IsOnePair(hand));
    }
        [TestMethod]
        public void IsFlushShouldReturnTrueTwoToSix()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
               {
                   new Card(CardFace.Two, CardSuit.Spades),
                   new Card(CardFace.Three, CardSuit.Clubs),
                  new Card(CardFace.Four, CardSuit.Hearts),
                   new Card(CardFace.Five, CardSuit.Diamonds),
                   new Card(CardFace.Six, CardSuit.Spades)
             };
            var hand = new Hand(cards);
            Assert.IsTrue(checker.IsFlush(hand));
        }

        [TestMethod]
        public void IsFlushShouldReturnFalseWhenNotMatchingHandPassed()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
               {
                   new Card(CardFace.Queen, CardSuit.Spades),
                   new Card(CardFace.Seven, CardSuit.Clubs),
                  new Card(CardFace.Eight, CardSuit.Hearts),
                   new Card(CardFace.King, CardSuit.Diamonds),
                   new Card(CardFace.King, CardSuit.Spades)
             };
            var hand = new Hand(cards);
            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestMethod]
        public void IsValidHandShouldReturnFiveOfAKind()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
               {
                   new Card(CardFace.Queen, CardSuit.Spades),
                   new Card(CardFace.Queen, CardSuit.Hearts),
                   new Card(CardFace.Queen, CardSuit.Diamonds),
                   new Card(CardFace.Queen, CardSuit.Spades)
             };
            var hand = new Hand(cards);
            checker.IsValidHand(hand);
        }

    }
}