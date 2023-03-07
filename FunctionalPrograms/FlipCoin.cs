using System;
namespace FunctionalPrograms
{
    public class FlipCoin
    {
        const double VALIDATION_CHECK = 0.5;
        public void Flip(int numOfTimes)
        {
            int head = 0, tail = 0;
            Random random = new Random();
            for (int i = 0; i < numOfTimes; i++)
            {
                double value = random.NextDouble();
                if (value < VALIDATION_CHECK)
                    tail++;                    
                else
                    head++;                  
            }
            double headPercentage = (head*100/numOfTimes);
            double tailPercentage = (tail*100/numOfTimes);
            Console.WriteLine("Head Percentage--->  " + headPercentage + "\nTail Percentage--->  " + tailPercentage);
        }
    }
}
