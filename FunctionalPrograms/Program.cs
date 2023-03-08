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
                    + "\n5.Prime Factors \n6.Even or Odd \n7.Vowels and Consonants \n8.Quotient and Remainder"+"" +
                    " \n9.Largest of Three Numbers \n10.Swap Two Numbers \n11.Exit");
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
                        Console.WriteLine("Enter number");
                        int numb = Convert.ToInt32(Console.ReadLine());
                        PrimeFactors primeFactors = new PrimeFactors();
                        primeFactors.Factors(numb);
                        break;
                    case 6:
                        Console.WriteLine("Enter number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        EvenOrOdd evenOrOdd = new EvenOrOdd();
                        evenOrOdd.EvenOdd(n);
                        break;
                    case 7:
                        Console.WriteLine("Enter an Alphabet");
                        char alpha = Convert.ToChar(Console.ReadLine());
                        VowelsOrConsonants vowels = new VowelsOrConsonants();
                        vowels.VowelsConsonants(alpha);
                        break;
                    case 8:
                        Console.WriteLine("Enter number");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter another num");
                        int b = Convert.ToInt32(Console.ReadLine());
                        QuotientAndRemainder quot = new QuotientAndRemainder();
                        quot.QuoAndRem(a, b);
                        break;
                    case 9:
                        Console.WriteLine("Enter num1");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter num2");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter num3");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        LargestOf3Num largestOf3Num = new LargestOf3Num();
                        largestOf3Num.LargestNum(num1, num2, num3);
                        break;
                    case 10:
                        Console.WriteLine("Enter num1");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter num2");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        SwapTwoNum swapTwoNum = new SwapTwoNum();
                        swapTwoNum.SwapNum(n1, n2);
                        break;
                    case 11:
                        flag = false;
                        break;
                }
            }    
        }
    }
}