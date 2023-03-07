using System;
namespace FunctionalPrograms
{
    public class PowerOfTwo
    {
        public void Power(int power) 
        { 
            for (int i = 0; i <= power; i++)
            {
                    Console.WriteLine("2^" + i + " = " + Math.Pow(2, i));
                if (i == 30)
                    break;
            }
        }
    }
}
