using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableASCII
{
    class TableASCII
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
              for (int i = 0; i < 256; i++)
              {
                  char a = (char)i;
                  Console.WriteLine(a);
              }
        }
    }
}
