using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before exchange\na= {0}\nb= {1}", a, b);
            int c = b = 10;
            b = a;
            a = c;
            Console.WriteLine("After exchange\na= {0}\nb= {1}", a, b);
        }
    }
}
