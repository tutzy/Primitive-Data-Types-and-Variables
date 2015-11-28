using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           
            if ((number == 1 || number == 2 || number == 3 || number == 5 || number == 7)
                    ^ (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0))
            {
                Console.WriteLine("The number is Prime");
            }
            else
                Console.WriteLine("The number is NOT Prime");
        }
    }
}



