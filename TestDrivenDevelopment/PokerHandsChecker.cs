using System;
using System.Linq;
namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("hand", "Hand cannot be null.");
            }
            if (hand.Cards.Count!=5)
            {
                throw new ArgumentException("Invalid hand.");
            }
                   return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }
            var isStraight = true;
            var sorted = hand.Cards.Select(value => (int)value.Face).OrderBy(value => value).ToArray();
            if (sorted.Contains((int)CardFace.Two) && sorted.Contains((int)CardFace.Six))   
            {
                var index = Array.IndexOf(sorted, (int)CardFace.Two);
                sorted[index] = 1;
                sorted = sorted.OrderBy(value => value).ToArray();
            }
            for (int ind = 0; ind < sorted.Length - 1; ind++)
                {
                     if (sorted[ind] + 1 != sorted[ind + 1])
                         {
                             isStraight = false;
                             break;
                         }
                }
             bool isFlush = hand.Cards.GroupBy(card => card.Suit).Count() == 1;
             return isStraight && isFlush;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
                     {
                          return false;
                      }
           var sorted = hand.Cards.GroupBy(card => card.Face);
                 return sorted.Any(gr => gr.Count() == 4);
       }

    public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            if (!this.IsValidHand(hand))
                  {
                       return false;
                  }
           var sorted = hand.Cards.GroupBy(card => card.Face);
            return sorted.Any(gr => gr.Count() == 4);
        }

    public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
