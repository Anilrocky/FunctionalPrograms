using System;
namespace FunctionalPrograms
{
    public class SwapTwoNum
    {
        public void SwapNum(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a value is: "+a);
            Console.WriteLine("b value is: "+b);
        }
    }
}
