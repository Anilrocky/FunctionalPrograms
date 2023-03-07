using System;
namespace FunctionalPrograms
{
    public class PrimeFactors
    {       
        public void Factors(int num)
        {
            int count = 0, flag = 0;
            for (int i = 2; i*i<=num; i++)
            {
                if (num%i == 0)
                {
                    for (int j = 1; j*j<=i; j++)
                    {
                        if ((i%j) == 0)
                            count++;
                    }
                    if (count == 2)
                        flag = 1;
                    Console.WriteLine("Prime Factors are: " + i);
                }
            }
        }
    }
}
