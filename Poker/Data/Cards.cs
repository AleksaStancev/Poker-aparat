using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Data
{
    public static class Cards
    {
        private static readonly string[] cardSymbol = { "C", "S", "H", "D" };
        private static readonly string[] cardValue = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "12", "13", "14"};
        private static readonly Random rnd = new Random();
        public static List<string> DealCards()
        {
            int i = 0;
            List<string> temp = new List<string>();
            while (i < 5)
            {
                string card = GetRandomCard();
                if (!temp.Contains(card))
                {
                    temp.Add(card);
                    i++;
                }
            }
            return temp;
        }

        public static void SwapCards(int numberOfCards,List<string> dealtCards, int[] selectedIndexesToSwap)
        {
            int i = 0;
            while (i < numberOfCards)
            {
                string card = GetRandomCard();
                if (!dealtCards.Contains(card)) dealtCards[selectedIndexesToSwap[i++]] = card;
            }
        }

        private static string GetRandomCard()
        {           
            int symbolIndex = rnd.Next(0, 4);
            int valueIndex = rnd.Next(0, 13);
            return cardSymbol[symbolIndex] + cardValue[valueIndex];
        }
    }
}
