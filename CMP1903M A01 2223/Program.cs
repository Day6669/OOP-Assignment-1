using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void PrintCard(Card card)
        {
            Console.WriteLine($"{card.Suit}-{card.Value}");
        }

        static void Main(string[] args)
        {

            //Card card = new Card();
            //card.Suit = suitType.Diamonds;
            //card.Value = 12;
            //Console.WriteLine(card);
            Pack pack = new Pack();
            Pack.shuffleCardPack(Pack.ShuffleType.FisherYatesShuffle);
            List<Card> cards = Pack.dealCard(10);

            foreach (Card c in cards)
            {
                PrintCard(c);
            }

            Console.ReadLine();
        }
    }
}
