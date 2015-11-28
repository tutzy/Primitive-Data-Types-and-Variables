using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyABitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            if(v==1)
            {
                int mask = 1 << p;
                int bit = n | mask;
                Console.WriteLine(bit);
            }
            else
            {
                int mask = ~(1 << p);
                int bit = n & mask;
                Console.WriteLine(bit);
            }
        }
    }
}
