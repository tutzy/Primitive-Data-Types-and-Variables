using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ComparingFloats
{
    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            string year = (string)(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double sum = (((52 - h) / 3) * 2) + (p / 2) + h;
            if (year == "t")
            {
                sum += 3;
            }
            Console.WriteLine((int)Math.Floor(sum));
        }
    }
}

