using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            string name = "World";
            object datacontainer = greeting + ' ' + name;
            string valueOfTheObject = (string)datacontainer;
            Console.WriteLine("string greeting= {0}\nstring name= {1}\nobject datacontainer: {2}\nstring valueOfTheObject: {3}",
                                greeting, name, datacontainer, valueOfTheObject);
        }
    }
}
