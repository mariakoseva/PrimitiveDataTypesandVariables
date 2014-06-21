using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteInStrings
{
    class Program
    {
        static void Main()
        {
            string firstStringString = "The \"use\" of quotations causes difficulties.";
            string secondString = " The ''use'' of quotations cause difficulties.";
            Console.WriteLine(firstStringString);
            Console.WriteLine(secondString);
        }
    }
}
