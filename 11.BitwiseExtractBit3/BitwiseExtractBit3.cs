using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int bit = n >> p;
            int findBit = bit & 1;
            Console.WriteLine(findBit);
        }
    }
}
