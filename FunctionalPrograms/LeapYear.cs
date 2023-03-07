using System;
namespace FunctionalPrograms
{
    public class LeapYear
    {
        public void Leap(int year)
        {
            if (year >= 1000)
            {
                if ((year % 4 == 0) || (year % 100 != 0 && year % 400 == 0))
                    Console.WriteLine(year + " is a Leap year");
                else
                    Console.WriteLine(year + " is not leap year");
            }
            else
                Console.WriteLine("Enter year in YYYY format only");
        }
    }
}
