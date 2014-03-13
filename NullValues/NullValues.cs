using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValues
{
    class NullValues
    {
        static void Main(string[] args)
        {
            int? first = null;
            double? number = null;

            Console.WriteLine(first.HasValue);
            Console.WriteLine(number.HasValue);

            first += 5;
            number += 3.33;
            Console.WriteLine(first);
            Console.WriteLine(number);
            Console.WriteLine("null + number return null again");
        }
    }
}
