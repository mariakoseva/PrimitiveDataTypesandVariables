using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
   class BankAccount
    {
        static void Main()
        {
            string firstName = "Maria";
            string middleName = "Koleva";
            string lastName = "Koseva";
            decimal money = 1000.01m;
            string bankName = "DSK";
            string iban = "BG01 UBWS 1000 1000 100 00";
            long cardNumber1 = 100000000000000;
            long cardNumber2 = 200000000000000;
            long cardNumber3 = 300000000000000;
            Console.WriteLine("{0} {1} {2}\nAvailable amount of money(balance): {3}\n{4} IBAN: {5}\nCard number 1: {6}\nCard number 2: {7}\nCard number 3: {8}", 
                firstName, middleName, lastName, money, bankName, iban, cardNumber1, cardNumber2, cardNumber3);
            }
        }
    }
