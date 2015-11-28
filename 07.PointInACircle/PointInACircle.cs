using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PodoubleInACircle
{
    class podoubleInACircle
    {
        static void Main(string[] args)
        {
            double x=double.Parse(Console.ReadLine());
            double y=double.Parse(Console.ReadLine());
            if (((x*x) + (y*y)) <= 2*2)
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
