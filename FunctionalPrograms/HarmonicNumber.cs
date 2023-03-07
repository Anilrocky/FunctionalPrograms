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
                Console.WriteLine("1/"+i + " = "+(1/i));
                result = (i+1)/i;               
            }
            Console.WriteLine("Harmonic Value of " + number + " is: " + result);
        }
    }
}
