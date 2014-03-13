using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareFloats
{
    class CompareFloats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparing floats with precision 0.000001");
            Console.WriteLine("Please enter first float for comparison:");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second float for comparison:");
            double second = double.Parse(Console.ReadLine());
            if ((first - second) <= 0.000001 && (first - second) >= -0.000001)
            {
                Console.WriteLine("True! Floats dont have bigger difference than 0.000001");
            }
            else
            {
                Console.WriteLine("False! Floats have difference bigger than 0.000001");
            }
        }
    }
}
