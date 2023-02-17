using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            // setup & running of tests
            Testing tests = new Testing();
            Console.WriteLine("====  Tests ==== \n");
            tests.RunTests();
        }
    }
}
