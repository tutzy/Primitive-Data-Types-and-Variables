using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Expressions_and_Statements
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            bool evenOrOdd = false;
            if(a%2==0)
            {
                Console.WriteLine(evenOrOdd);
            }
            else
            {
                evenOrOdd = true;
                Console.WriteLine(evenOrOdd);
            }
        }
    }
}
