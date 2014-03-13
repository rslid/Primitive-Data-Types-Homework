using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    class Exchange
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("In the beginning \"a\" have value {0} and \"b\" {1}",a,b);
            Console.WriteLine();
            a = a + b;
            b = a-b;
            a = a - b;
            Console.WriteLine("Now a is {0} and b is {1}", a,b);

            // Or we can do it like this 
            Console.WriteLine("\nOr we can use this\n");
            int first = 5;
            int second = 10;
            int temp;
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("Now a is {0} and b is {1}", first,second);


        }
    }
}
