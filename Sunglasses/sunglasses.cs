using System;
class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string lens = new string ('/', 2 * n - 1);
        string empty = new string (' ', n);
        string bridge = new string ('|', n);
        string lensFrame = string.Format ("{0}{1}{0}", '*', lens);
        string frame =new string('*', 2 * n);
         if (n%2==0)
            {
                Console.WriteLine("Invalid Input");
            }
         else
         {
             for (int i = 0; i < n; i++)
             {

                 if (i == 0 || i == n - 1)
                 {
                     Console.WriteLine("{0}{1}{0},", frame, empty);  //print first and last row
                 }
                 else if (i == n / 2)
                 {
                     Console.WriteLine("{0}{1}{0}", lensFrame, bridge);
                 }
                 else
                 {
                     Console.WriteLine("{0}{1}{0}", lensFrame, empty);
                 }
             }
        }
    }
}