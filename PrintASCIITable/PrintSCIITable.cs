using System;
using System.Text;

class AsciiTableOfSymbols
{
    static void Main()
    {
        for (int i = 1; i <= 255; i++)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("{0}->{1}", i, (char)i);
            if (char.IsDigit((char)i))
            {
                Console.WriteLine("{0}->{1}", i, (char)i);
            }
        }
    }
}
