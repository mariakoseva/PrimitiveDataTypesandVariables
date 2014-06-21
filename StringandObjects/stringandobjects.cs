using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringandObjects
{
    class Program
    {
        static void Main()
        {
            string greeting = "Hello";
            string world = "World!";
            object newGreetingCSharp = greeting + " " + world;
            Console.WriteLine(newGreetingCSharp);

            string thirdGreeting = (string)newGreetingCSharp;
            Console.WriteLine(thirdGreeting);
        }
    }
}
