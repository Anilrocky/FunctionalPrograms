using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FunctionalPrograms
{
    public class QuotientAndRemainder
    {
        public void QuoAndRem(int div,int mod)
        {
            int Quotient = div / mod;
            Console.WriteLine("Quotient is: "+Quotient);
            int Remainder = div % mod;
            Console.WriteLine("Remainder is: "+Remainder);

        }
    }
}
