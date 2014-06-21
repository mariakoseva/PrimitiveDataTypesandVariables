using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class Nullvalues
    {
        static void Main()
        {
            int? value = null;
            int? valueTwo = null ;

            int? nullMathValue = value + null;
            int? nullMathValueTwo = valueTwo + 5;
            Console.WriteLine(value);
            Console.WriteLine(valueTwo);
            Console.WriteLine(nullMathValue);
            Console.WriteLine(nullMathValueTwo);
        }
    }
}
