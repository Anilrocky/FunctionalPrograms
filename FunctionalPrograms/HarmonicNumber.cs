using System;
namespace FunctionalPrograms
{
    public class HarmonicNumber
    {
        public void Harmonic(double number)
        {
            double result = 0;
            for (double i = 1; i <=number; i++)
            {
                result += 1 / i;
                Console.WriteLine("1/{0}+1/{0}" + i, result);
            }            
            Console.WriteLine("Harmonic Value of " + number + " is: " + result);
        }
    }
}
