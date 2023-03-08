using System;
namespace FunctionalPrograms
{
    public class LargestOf3Num
    {
        public void LargestNum(int a,int b,int c) 
        {
            if (a > b && a > c)
                Console.WriteLine("Largest Number is: {0}", a);
            if (b > a && b>c) 
                Console.WriteLine("Largest Number is: {0}", b);
            else
                Console.WriteLine("Largest Number is: {0}", c);
        }
    }
}
