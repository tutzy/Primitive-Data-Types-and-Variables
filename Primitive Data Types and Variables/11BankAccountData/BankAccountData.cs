using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string middleName = "Doe";
            string lastName = "Doe";
            decimal money = 1234567.12345678989m;
            string bankName = "Burkan Bank";
            string iban = "BG32 FIBS 1234 5678 1234 56";
            long cardNumber1 = 123456789012345;
            long cardNumber2 = 098765432109876;
            long cardNumber3 = 019283746501928;
            Console.WriteLine("Name: {0} {1} {2}\nAvailable amount of money: {3}\nBank: {4}\nIBAN: {5}\nCard number: {6}\nCard number: {7}\nCard number: {8}", 
                firstName, middleName, lastName, money, bankName, iban, cardNumber1, cardNumber2, cardNumber3);
        }
    }
}
