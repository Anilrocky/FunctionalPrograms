using System;
namespace FunctionalPrograms
{
    public class PowerOfTwo
    {
        public void Power(int power) 
        { 
            for (int i = 0; i <= power && power<31; i++)
            {
                Console.WriteLine("2^" + i + " = " + Math.Pow(2, i));
            }
        }
    }
}
