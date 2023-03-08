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
                Console.Write("1/"+i+"+",result);
                result += 1 / i;
            }            
            Console.WriteLine("\nHarmonic Value of " + number + " is: " + result);
        }
    }
}
