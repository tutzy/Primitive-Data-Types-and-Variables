using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool check = true;
            if(Math.Abs(a-b)<eps)
            {
                Console.WriteLine(check);
            }
            else
            {
                check=false;
                Console.WriteLine(check);
            }
        }
    }
}
