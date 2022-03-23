using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputationProgram
{
    internal class DisplayComarisonResult
    {
        double lineLength1, lineLength2;
        public void FirstLineLength()
        {
            double x1, y1, x2, y2;

            Console.WriteLine("\nEnter first point X coordinate x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter first point Y coordinate y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter second point X coordinate x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second point Y coordinate y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            double powerx = Math.Pow((x2 - x1), 2);
            double powery = Math.Pow((y2 - y1), 2);

            lineLength1 = Math.Sqrt((powerx + powery));

            Console.WriteLine($"\nLength of line using two points ({x1},{y1}) and ({x2},{y2}) is : {lineLength1}");
        }

        public void SecondLineLength()
        {
            double x1, y1, x2, y2;

            Console.WriteLine("\nEnter first point X coordinate x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter first point Y coordinate y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter second point X coordinate x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second point Y coordinate y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            double powerx = Math.Pow((x2 - x1), 2);
            double powery = Math.Pow((y2 - y1), 2);

            lineLength2 = Math.Sqrt((powerx + powery));

            Console.WriteLine($"\nLength of line using two points ({x1},{y1}) and ({x2},{y2}) is : {lineLength2}");
        }

        public void DisplayResult()
        {
            int result = lineLength1.CompareTo(lineLength2);

            Console.WriteLine($"\n\nLength of First Line: {lineLength1}");
            Console.WriteLine($"Length of Second Line: {lineLength2}");

            if (result > 0)
                Console.WriteLine($"\n So First line is greater than Second line");

            else if (result < 0)
                Console.WriteLine($"\n So First line is less than Second line");

            else
                Console.WriteLine($"\nSo First Line and Second Line Both are Equal");
                                       
        }
    }
}
