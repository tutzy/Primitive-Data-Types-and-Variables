using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = (2 * width) + (2 * height);
            double area = width * height;
            Console.WriteLine("perimeter = {0}\narea = {1}", perimeter, area);

        }
    }
}
