using Poker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Model
{
    public class PokerModel
    {
        private int points;
        private int bet;
        private List<string> hand;
        public PokerModel()
        {}

        public int Points { get => points; set => points = value; }
        public int Bet { get => bet; set => bet = value; }

        public string[] GetHand()
        {
            return hand.ToArray();
        }

        public void Deal()
        {
            hand = Cards.DealCards();
        }
        public void Swap(int numberOfCards, params int[] indexes)
        {
            Cards.SwapCards(numberOfCards, hand, indexes);
        }

        public int EvaluateHand(out string message)
        {
            int value = 0;
            hand.Sort(HandSortValue);
            message = "Nema dobitka!";
            //one pair
            if (HasPair(false))
            {
                //two pairs
                if (HasPair(true))
                {
                    //four of a kind
                    if (hand[0].Substring(1) == hand[2].Substring(1))
                    {
                        value = 60;
                        message = "Cetiri iste karte!";
                    }
                    //full house or blaze
                    else if (IsFull())
                    {
                        value = 24;
                        message = "Full House!";
                    }
                    else if (IsBlaze())
                    {
                        value = 9;
                        message = "Blaze!";
                    }
                    else
                    {
                        value = 4;
                        message = "Dva para!";
                    }

                }
                //blaze, three of a kind od big bobtail
                else
                {
                    List<string> temp = new List<string>(hand);
                    temp.Sort(HandSortSymbolValue);
                    if (IsBigBobtail(temp))
                    {
                        value = 40;
                        hand = temp;
                        message = "Big bobtail!";
                    }
                    else
                    {
                        if (IsBlaze())
                        {
                            value = 9;
                            message = "Blaze!";
                        }
                        else if (IsThreeOfAKind())
                        {
                            value = 6;
                            message = "Tri iste karte!";
                        }
                        else
                        {
                            value = 2;
                            message = "Par!";
                        }
                    }
                }
            }
            else
            {
                hand.Sort(HandSortSymbolValue);
                bool flush = IsFlush(0, 4);
                bool straight = IsStraignt(0, 4);
                //straight flush
                if (straight && flush)
                {
                    value = 100;
                    message = "Strejt fles!";
                }
                //big bobtail
                else if (IsBigBobtail(hand))
                {
                    value = 40;
                    message = "Big bobtail!";
                }
                //flush
                else if (flush)
                {
                    value = 16;
                    message = "Fles!";
                }
                //straight
                else if (straight)
                {
                    value = 12;
                    message = "Strejt!";
                }
                else hand.Sort(HandSortValue);
            }
            return value;
        }
        private bool HasPair(bool secondPair)
        {
            int i;
            int factor = i = secondPair ? 2 : 0;
            while (i < 4)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if(hand[i].Substring(1)== hand[j].Substring(1))
                    {

                        CardSwap(factor, i);
                        CardSwap(factor+1, j);
                        return true;
                    }
                }
                i++;
            }
            return false;         
        }
        private bool IsThreeOfAKind()
        {
            string kind = hand[0].Substring(1);
            for (int i = 2; i < 5; i++)
            {
                if (hand[i].Substring(1) == kind)
                {
                    CardSwap(2, i);
                    return true;
                }
            }
            return false;
        }
        private bool IsBlaze()
        {
            string[] faceCards = {"14", "13", "12" };
            foreach (var card in hand)
            {
                if (!faceCards.Contains(card.Substring(1))) return false;            
            }
            hand.Sort(HandSortValue);
            return true;
        }
        private bool IsFlush(int start, int end)
        {
            char compare = hand[start++][0];
            for (int i = start; i <= end; i++)
            {
                if (compare != hand[i][0]) return false;    
            }
            return true;
        }
        private bool IsFull()
        {
            bool swap1 = hand[0].Substring(1) == hand[4].Substring(1);
            if (swap1 || hand[2].Substring(1) == hand[4].Substring(1))
            {
                if (swap1) CardSwap(2, 4);
                else
                {
                    CardSwap(0, 3);
                    CardSwap(1, 4);
                }
                return true;
            }
            return false;
        }
        private bool IsStraignt(int start, int end)
        {
            int high = Convert.ToInt32(hand[start++].Substring(1));
            int low = Convert.ToInt32(hand[end].Substring(1));
            if (high!=14 || low!=1)
            {
                int test = high;
                for (int i = start; i <= end; i++)
                {
                    if (test != Convert.ToInt32(hand[i].Substring(1)) + 1) return false;
                    test--;
                }
            }
            else
            {
                int i = start;
                int test = high;
                while (i < end)
                {
                    if (test != Convert.ToInt32(hand[i].Substring(1)) + 1) break;
                    test--;
                    i++;
                }
                test = low;
                for (int j = end - 1; j >= i ; j--)
                {
                    if (test != Convert.ToInt32(hand[j].Substring(1)) - 1) return false;
                    test++;
                }
            }
            return true;
        }
        private bool IsBigBobtail(List<string> hand)
        {
            bool shift;
            if ((shift = IsStraignt(1, 4) && IsFlush(1, 4)) || (IsStraignt(0, 3) && IsFlush(0, 3)))
            {

                if (shift)
                {
                    string temp = hand[0];
                    for (int i = 0; i < 4; i++)
                    {
                        hand[i] = hand[i + 1];
                    }
                    hand[4] = temp;
                }
                return true;
            }
            return false;
        }
        private void CardSwap(int index1, int index2)
        {
            if (index1 != index2)
            {
                string temp = hand[index1];
                hand[index1] = hand[index2];
                hand[index2] = temp;
            }
        }
        private int HandSortValue(string card1, string card2)
        {
            if (Convert.ToInt32(card1.Substring(1)) < Convert.ToInt32(card2.Substring(1))) return 1;
            else return -1;

        }
        private int HandSortSymbolValue(string card1, string card2)
        {
            char card1Symbol = card1[0], card2Symbol = card2[0];
            if (card1Symbol == card2Symbol) return HandSortValue(card1, card2);
            else if (card1Symbol == 'H') return 1;
            else if (card1Symbol == 'D') return -1;
            else if (card1Symbol == 'S')
            {
                if (card2Symbol == 'D') return 1;
                else return -1;
            }
            else if (card2Symbol == 'H') return -1;
            else return 1;
        }
    }
}
