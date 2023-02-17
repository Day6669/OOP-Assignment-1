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
            Testing tests = new Testing();
            Console.WriteLine("====  Tests ==== \n");
            tests.RunTests();
        }
    }
}
