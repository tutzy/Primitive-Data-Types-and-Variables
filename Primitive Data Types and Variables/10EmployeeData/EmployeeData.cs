using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";
            byte age = 22;
            char geneder = '\u2642';
            ulong idNumber = 9301016263;
            ulong uniqueID = 2756000027569999;
            Console.WriteLine("First name: {0}\nLast Name: {1}\nAge: {2}\nGeneder: {3}\nIDNumber: {4}\nUniqueID: {5}",
                firstName, lastName, age, geneder, idNumber, uniqueID);
        }
    }
}
