using System;
using System.Linq;

namespace HalfSum
{
    class HalfSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int[] arrayTwo = new int[n];
            int sum = 0;
            int sumTwo = 0;
            for (int i = 0; i <array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
               sum = array.Sum();
            }
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                arrayTwo[i] = int.Parse(Console.ReadLine());
                sumTwo = arrayTwo.Sum();
            }
            
            int diff = sum - sumTwo;
            diff = Math.Abs(diff);
            if (diff == 0)
            {
                Console.WriteLine("Yes, sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", diff);
            }
        }
    }
}
