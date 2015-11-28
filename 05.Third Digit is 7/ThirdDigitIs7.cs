using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Third_Digit_is_7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            int thirddigit = (number / 100) % 10;

            bool result = thirddigit == 7;
            Console.WriteLine("The third digit from right-to-left is 7 is:" + result);
        }
    }
}
