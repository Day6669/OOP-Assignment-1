using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    // collection type to hold the cards
    class Pack
    {

        static private List<Card> pack;

        static public List<Card> getPack()
        {
            // public getter for private attribute
            return pack;
        }
        // methods for getting random variables
        private static Random random = new Random(0);
        private static int RandRange(int from, int to)
        {
            return random.Next(from, to);
        }
        // data type for card faces
        public enum CardFaces
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
        }

        public enum ShuffleType
        {
            NoShuffle = 1,
            RiffleShuffle =2,
            FisherYatesShuffle = 3,
        }

        public Pack()
        {
            //Creates the card pack here.
            pack = new List<Card>();

            foreach (var suit in Enum.GetValues(typeof(suitType)))
            {
                foreach (var face in Enum.GetValues(typeof(CardFaces)))
                    //Loop to create card from all 13 cards from each suit.
                {
                    Card card = new Card();
                    card.Suit = (suitType)suit;
                    card.Value = (int)face;
                    pack.Add(card);

                }
            }
        }
        

        public static bool shuffleCardPack(ShuffleType typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == ShuffleType.NoShuffle)
            {
                return true;
            }
            
            else if (typeOfShuffle == ShuffleType.RiffleShuffle)
            {
                // find the middle
                decimal half = pack.Count / 2;
                // round the middle to a whole number
                int parts = (int)Math.Floor(half);
                // create a new list for the shuffle
                List<Card> shuffled = new List<Card>();

                // add cards from each half into the new array
                for (int i = 0; i < parts; i++)
                {
                    shuffled.Add(pack[i]);
                    shuffled.Add(pack[parts + i]);
                }
                pack = shuffled;
            }

            else if (typeOfShuffle == ShuffleType.FisherYatesShuffle)
            {
                // loop all cards
                for (int i = 0; i < pack.Count - 1; i++)
                {
                    // generate random number
                    int randomIndex = RandRange(i, pack.Count);
                    // swap cards around (current <-> random)
                    Card temp = pack[i];
                    pack[i] = pack[randomIndex];
                    pack[randomIndex] = temp;
                }
            }

            return true;
        }

        public static Card deal()
        {
            //Deals one card
            return pack[0];

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> items = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                items.Add(pack[i]);
            }

            return items;
        }
    }
}
