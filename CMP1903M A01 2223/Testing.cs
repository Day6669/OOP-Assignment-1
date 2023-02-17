using System.Collections.Generic;
using System;

namespace CMP1903M_A01_2223
{
	public class Testing
	{
		private static Pack testPack;

		public Testing()
		{
			setup();
		}

		public void setup()
		{
			testPack = new Pack();
		}

		private static string FormatCard(Card card)
		{
			return $"{card.Suit}-{card.Value}";
        }

		private static string FormatCards(List<Card> cards)
		{
			string outputCards = "";
			foreach (Card card in cards)
			{
				outputCards += FormatCard(card);
			}
			
			return outputCards;
		}

		private static bool RiffleShuffleTest()
		{
			Pack.shuffleCardPack(Pack.ShuffleType.RiffleShuffle);
			string cards = FormatCards(Pack.getPack());
			string expected = "Diamonds-1Hearts-1Diamonds-2Hearts-2Diamonds-3Hearts-3Diamonds-4Hearts-4Diamonds-5Hearts-5Diamonds-6Hearts-6Diamonds-7Hearts-7Diamonds-8Hearts-8Diamonds-9Hearts-9Diamonds-10Hearts-10Diamonds-11Hearts-11Diamonds-12Hearts-12Diamonds-13Hearts-13Spades-1Clubs-1Spades-2Clubs-2Spades-3Clubs-3Spades-4Clubs-4Spades-5Clubs-5Spades-6Clubs-6Spades-7Clubs-7Spades-8Clubs-8Spades-9Clubs-9Spades-10Clubs-10Spades-11Clubs-11Spades-12Clubs-12Spades-13Clubs-13";

			return cards == expected;
			
		}

		private static bool DealRiffleTest()
		{
			Card card = Pack.deal();
			string cards = FormatCard(card);
            string expected = "Clubs-6";

            return cards == expected;
        }

        private static bool DealCardRiffleShuffle()
        {
            string expectedString = "Diamonds-1Hearts-1Diamonds-2Hearts-2Diamonds-3Hearts-3Diamonds-4Hearts-4Diamonds-5Hearts-5";
            int expectedLength = 10;
            List<Card> cards = Pack.dealCard(expectedLength);
            string dealtcards = FormatCards(cards);
            Console.WriteLine(dealtcards);

            return ((dealtcards == expectedString) && (cards.Count == expectedLength));
        }

        private static bool FischerYatesShuffleTest()
        {
            Pack.shuffleCardPack(Pack.ShuffleType.FisherYatesShuffle);
            string cards = FormatCards(Pack.getPack());
            string expected = "Clubs-6Spades-9Spades-8Spades-3Hearts-7Clubs-3Clubs-11Spades-1Clubs-13Diamonds-11Diamonds-12Hearts-2Diamonds-1Hearts-3Diamonds-5Diamonds-9Diamonds-4Diamonds-8Clubs-8Clubs-2Spades-11Hearts-8Hearts-9Hearts-12Clubs-9Clubs-7Spades-13Spades-10Diamonds-10Hearts-6Spades-5Diamonds-2Diamonds-7Diamonds-6Clubs-10Hearts-11Spades-6Hearts-1Spades-4Clubs-4Hearts-5Spades-12Diamonds-13Hearts-10Hearts-13Hearts-4Spades-2Clubs-12Diamonds-3Clubs-5Spades-7Clubs-1";

            return cards == expected;
        }


        private static bool DealCardFischerTest()
		{
			string expectedString = "Clubs-6Spades-9Spades-8Spades-3Hearts-7Clubs-3Clubs-11Spades-1Clubs-13Diamonds-11";
			int expectedLength = 10;
			List<Card> cards = Pack.dealCard(expectedLength);
			string dealtcards = FormatCards(cards);

			return ((dealtcards == expectedString) && (cards.Count == expectedLength));
		}


        private static bool DealFischerTest()
        {
            Card card = Pack.deal();
            string cards = FormatCard(card);
            string expected = "Clubs-6";

            return cards == expected;
        }



		public void RunTests()
		{
			int passed = 0;
			int totalTests = 6;

			if (RiffleShuffleTest())
			{
				passed++;
				Console.WriteLine("Riffleshuffle Test [Passed]");
			}
			else
			{
				Console.WriteLine("Riffleshuffle Test [Failed]");
			}
            if (DealCardRiffleShuffle())
            {
                passed++;
                Console.WriteLine("Riffle Shuffle Deal Cards Test [Passed]");
            }
            else
            {
                Console.WriteLine("Riffle Shuffle Deal Cards Test [Failed]");
            }

            if (FischerYatesShuffleTest())
            {
                passed++;
                Console.WriteLine("Fischer-Yates Shuffle Test [Passed]");
            }
            else
            {
                Console.WriteLine("Fischer-Yates Shuffle [Failed]");
            }

            if (DealFischerTest())
            {
                passed++;
                Console.WriteLine("Fischer-Yates Deal Test [Passed]");
            }
            else
            {
                Console.WriteLine("Fischer-Yates Deal Test [Failed]");
            }

            if (DealRiffleTest())
            {
                passed++;
                Console.WriteLine("Riffle Shuffle Deal Test [Passed]");
            }
            else
            {
                Console.WriteLine("Riffle Shuffle Deal [Failed]");
            }

            if (DealCardFischerTest())
            {
                passed++;
                Console.WriteLine("Fischer-Yates Deal Cards Test [Passed]");
            }
            else
            {
                Console.WriteLine("Fischer-Yates Deal Cards Test [Failed]");
            }

			Console.WriteLine($"{passed}/{totalTests} Passed");	
		}
	}
}

