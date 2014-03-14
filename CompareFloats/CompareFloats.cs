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

            Console.Write("Please enter the first number: ");
            double first = Double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            double second = Double.Parse(Console.ReadLine());
            bool compare = (Math.Abs(first - second) < 0.000001);
            Console.WriteLine("Are the numbers equal with  precision 0.000001? : {0}", compare);
        }
    }
}
