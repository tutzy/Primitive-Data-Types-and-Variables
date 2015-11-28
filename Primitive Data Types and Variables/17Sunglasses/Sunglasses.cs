using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new String('*', n * 2) + new String(' ', n) + new String('*', n * 2));
            for (int i = 0; i < (n - (n / 2) - 2); i++)
            {
                Console.WriteLine(new String('*', 1) + new String('/', (n * 2) - 2) + new String('*', 1)
                + new String(' ', n) + new String('*', 1) + new String('/', (n * 2) - 2) + new String('*', 1));
            }
            Console.WriteLine(new String('*', 1) + new String('/', (n * 2) - 2) + new String('*', 1)
                + new String('|', n) + new String('*', 1) + new String('/', (n * 2) - 2) + new String('*', 1));
            for (int i = 0; i < (n - (n / 2) - 2); i++)
            {
                Console.WriteLine(new String('*', 1) + new String('/', (n * 2) - 2) + new String('*', 1)
                + new String(' ', n) + new String('*', 1) + new String('/', (n * 2) - 2) + new String('*', 1));
            }
            Console.WriteLine(new String('*', n * 2) + new String(' ', n) + new String('*', n * 2));
        }

    }
}
