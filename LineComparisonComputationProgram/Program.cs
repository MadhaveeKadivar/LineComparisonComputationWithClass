using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

           // FindLineLength findLineLength = new FindLineLength();
           // findLineLength.Length();

            TwoLineComparison twoLineComparison = new TwoLineComparison();
            Console.WriteLine("\nFor First Line......");
            twoLineComparison.FirstLineLength();
            Console.WriteLine("\n\nFor Second Line......");
            twoLineComparison.SecondLineLength();
            Console.WriteLine("\n\nComparison between lines....");
            twoLineComparison.Comparison();

            Console.ReadLine();
        }
    }
}
