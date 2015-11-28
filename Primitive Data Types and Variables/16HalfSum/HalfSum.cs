using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumFirstLine = 0;
            for (int i = 0; i < (n * 2) / 2; i++)
            {
                int result = int.Parse(Console.ReadLine());
                sumFirstLine = sumFirstLine + result;
            }
            int sumSecondLine = 0;
            for (int i = 0; i < (n * 2) / 2; i++)
            {
                int resultTwo = int.Parse(Console.ReadLine());
                sumSecondLine = sumSecondLine + resultTwo;
            }
            if (sumFirstLine == sumSecondLine)
            {
                Console.WriteLine("Yes, sum={0}", sumFirstLine);
            }
            else
            {
                
                Console.WriteLine("No, diff={0}", Math.Abs(sumFirstLine - sumSecondLine));
            }
        }
    }
}

