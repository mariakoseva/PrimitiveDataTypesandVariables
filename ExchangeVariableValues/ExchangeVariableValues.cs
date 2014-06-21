using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("a = {0}", b);

            int c;
            c = a = 5;
            b = c;
            Console.WriteLine("b = {0}", b);

            int d;
            d = a = 10;
            b = d;
            Console.WriteLine("a = {0}", a);

            
        }
    }
}
