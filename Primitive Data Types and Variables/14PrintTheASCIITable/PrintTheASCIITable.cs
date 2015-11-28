using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 256; i++)

            {
                Console.BufferHeight = 257;
                Console.Write((int)i);
                Console.Write(" = ");
                Console.WriteLine((char)i);
                
            }
        }
    }
}
