using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public enum suitType
    {
        Diamonds = 1,
           Spades = 2,
           Hearts = 3,
           Clubs = 4,
    }
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        private suitType suitValue;
        private int cardValue;


        public int Value
        {
            get
            {
                return cardValue;
            }

            set
            {
                if (value <= 13 && value >= 1)
                {
                    cardValue = value;
                }
                else
                {
                    Console.WriteLine("Value given is too large or too smol");
                }
            }
        }
        public suitType Suit {
            get
            {
                return suitValue;
            }
            set
                
            {
                suitValue = value;
            }

         }
    }
}
