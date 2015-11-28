using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("null values\na= {0}\nb= {1}",a,b);
            a = 5;
            b = 10;
            Console.WriteLine("After adding\na= {0}\nb= {1}",a,b);

        }
    }
}
