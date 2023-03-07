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
                Console.WriteLine("Choose an Option to Perform\n1.Flip Coin\n2.Exit");
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
                        flag = false;
                        break;
                }
            }    
        }
    }
}