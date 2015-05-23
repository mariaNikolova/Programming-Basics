using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static bool Prime(uint n)
        {
            uint divider = 2;
            uint maxDivider = (uint)Math.Sqrt(n);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (n % divider == 0)
                {
                    prime = false;
                }
                else
                {
                    divider++;
                }

            }
            
            if (prime)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
           Console.WriteLine(Prime(number));
        }
    }
}
