using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GravitationOnthe_Moon
{
    class GravitationOntheMoon
    {
        static void Main(string[] args)
        {
            double weightOnEarth = double.Parse(Console.ReadLine());
            double weightOnMoon = weightOnEarth * 0.17;
            Console.WriteLine(weightOnMoon);

        }
    }
}
