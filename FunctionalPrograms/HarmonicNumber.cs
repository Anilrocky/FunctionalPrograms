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
                Console.Write("1/"+i);
                result += 1 / i;
                if (i<number)
                    Console.Write("+");
            }            
            Console.WriteLine("\nHarmonic Value of " + number + " is: " + result);
        }
    }
}
