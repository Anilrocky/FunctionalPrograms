using System;
namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Problem Statements");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an Option to Perform\n1.Flip Coin\n2.Leap Year \n3.Power of Two\n4.Nth Harmonic Number"
                    + "\n5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        Console.WriteLine("Enter number of Flips");
                        int num = Convert.ToInt32(Console.ReadLine());
                        flipCoin.Flip(num);
                        break;
                    case 2:
                        Console.WriteLine("Enter year");
                        int year = Convert.ToInt32(Console.ReadLine());
                        LeapYear leapYear = new LeapYear();
                        leapYear.Leap(year);
                        break;
                    case 3:
                        PowerOfTwo powerOfTwo = new PowerOfTwo();
                        Console.WriteLine("Enter power");
                        int power = Convert.ToInt32(Console.ReadLine());
                        powerOfTwo.Power(power);
                        break;
                    case 4:
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        Console.WriteLine("Enter number");
                        double number= Convert.ToInt32(Console.ReadLine());
                        harmonicNumber.Harmonic(number);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }    
        }
    }
}