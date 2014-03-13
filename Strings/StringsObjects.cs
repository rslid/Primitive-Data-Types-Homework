using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class StringsObjects
    {
        static void Main(string[] args)
        {
            string hi = "Hello ";
            string world = "World!";
            object hiWorld = hi + world;
            string hiAgain = (string) hiWorld;
            Console.WriteLine(hiAgain);
        }
    }
}
