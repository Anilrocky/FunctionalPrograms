using System;
namespace FunctionalPrograms
{
    public class EvenOrOdd
    {
        public void EvenOdd(int num)
        {
            if (num % 2 == 0)
                Console.WriteLine("{0} is Even", num);
            else
                Console.WriteLine("{0} is Odd", num);
        }
    }
}
