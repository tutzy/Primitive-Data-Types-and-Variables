using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());//1234
            int first = (a / 1000) % 100;//1
            int second = (a / 100) % 10;//2
            int third = (a / 10) % 10;//3
            int fourth = (a / 1) % 10;//4
            int sum = first + second + third + fourth;
            Console.WriteLine("sum = {0}\nreversed = {1}{2}{3}{4}\nlast digit in front = {5}{6}{7}{8}\nsecond and third digits exchanged = {9}{10}{11}{12} "
                , sum, fourth, third, second, first, fourth, first, second, third, first, third, second, fourth);
        }
    }
}
