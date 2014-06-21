using System;

namespace JoroTheFootballPlayer
{
    class Program
    {
        static void Main()
        {
            string leap = Console.ReadLine(); //if the year is leap
            int p = int.Parse(Console.ReadLine());   //number of holidays
            int h = int.Parse(Console.ReadLine());   //number of weekend Joro spends in his hometown

            if (leap == "f")
            {
             int holidayPlay = p / 2;
             int normalWeekendPlayCount = ((52 - h) * 2) / 3;
             int hownTownPlayCount = h;
             int playFootball = holidayPlay + normalWeekendPlayCount + hownTownPlayCount;
             Console.WriteLine(playFootball);
            }
            else if (leap == "t")                // check if the year is not leap
            {
                int holidayPlay = p / 2;
                int normalWeekendPlayCount = ((52 - h) * 2) / 3;
                int hownTownPlayCount = h;
                int playFootball = holidayPlay + normalWeekendPlayCount + hownTownPlayCount +3;
                Console.WriteLine(playFootball);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }
    }
}
