using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            if (a % 5 == 0 & a % 7 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

    }
}
