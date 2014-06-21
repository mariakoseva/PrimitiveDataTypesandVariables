using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter the first number :");
        decimal firstNum = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number :");
        decimal secondNum = decimal.Parse(Console.ReadLine());

        if (Math.Abs(firstNum - secondNum) < 0.000001m)
            Console.WriteLine("The two numbers are equal with precision 0.000001");
        else
            Console.WriteLine("Difference between numbers (or equal to) 0.000001");
    }
}