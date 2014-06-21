using System;


namespace VariableinHexadecimalFormat
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Please enter a valid number");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Your number in hexadecimal is: {0:x}", number); 
            }
            else
            {
                System.Console.WriteLine("  The number is invalid!");
            }
           
        }
    }
}