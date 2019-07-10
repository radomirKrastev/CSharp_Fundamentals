namespace CardsGame
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            int smallerCountOfCards = firstPlayerCards.Count;

            while (smallerCountOfCards > 0)
            {
                for (int i = 0; i < smallerCountOfCards; i++)
                {
                    int firstPlayerCard = firstPlayerCards[0];
                    int secondPlayerCard = secondPlayerCards[0];

                    firstPlayerCards = GetFirstPlayerCards(firstPlayerCards
                        , secondPlayerCards
                        , firstPlayerCard
                        , secondPlayerCard);
                    secondPlayerCards=GetSecondPlayerCards(firstPlayerCards
                        , secondPlayerCards
                        , firstPlayerCard
                        , secondPlayerCard);
                }
                smallerCountOfCards = Math.Min(firstPlayerCards.Count, secondPlayerCards.Count);
            }

            int winnerTotalCardsSum = 0;
            if (firstPlayerCards.Count != 0)
            {
                for (int i = 0; i < firstPlayerCards.Count; i++)
                {
                    winnerTotalCardsSum += firstPlayerCards[i];
                }
                Console.WriteLine($"First player wins! Sum: {winnerTotalCardsSum}");
            }
            else
            {
                for (int i = 0; i < secondPlayerCards.Count; i++)
                {
                    winnerTotalCardsSum += secondPlayerCards[i];
                }
                Console.WriteLine($"Second player wins! Sum: {winnerTotalCardsSum}");
            }

            
        }

        public static List<int> GetFirstPlayerCards(List<int> firstPlayerCards
            , List<int> secondPlayerCards
            , int firstPlayerCard
            , int secondPlayerCard)
        {
            if (firstPlayerCard > secondPlayerCard)
            {
                firstPlayerCards.Add(firstPlayerCard);
                firstPlayerCards.Add(secondPlayerCard);
                firstPlayerCards.Remove(firstPlayerCard);
            }
            else if (firstPlayerCard < secondPlayerCard || firstPlayerCard == secondPlayerCard)
            {
                firstPlayerCards.Remove(firstPlayerCard);
            }

            return firstPlayerCards;
        }

        public static List<int> GetSecondPlayerCards(List<int> firstPlayerCards
            , List<int> secondPlayerCards
            , int firstPlayerCard
            , int secondPlayerCard)
        {
            if (firstPlayerCard > secondPlayerCard || firstPlayerCard == secondPlayerCard)
            {
                secondPlayerCards.Remove(secondPlayerCard);
            }
            else if(firstPlayerCard < secondPlayerCard)
            {
                
                secondPlayerCards.Add(secondPlayerCard);
                secondPlayerCards.Add(firstPlayerCard);
                secondPlayerCards.Remove(secondPlayerCard);
            }

            return secondPlayerCards;
        }
    }
}
