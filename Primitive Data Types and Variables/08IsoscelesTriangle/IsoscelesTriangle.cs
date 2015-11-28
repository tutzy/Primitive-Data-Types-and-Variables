using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding =Encoding.UTF8;
            char a= '\u00A9';
            char b = ' ';
            Console.WriteLine("{1}{1}{1}{0}\n{1}{1}{0}{1}{0}\n{1}{0}{1}{1}{1}{0}\n{0}{1}{0}{1}{0}{1}{0}{1}",a,b);
        }
    }
}
