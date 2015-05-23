using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (n == 1 || n==0)
            {
                Console.WriteLine(false);
            }
            else
            {

                for (int i = 2; i < n; i++)
                {
                    //isPrime = true;
                    if (n % i == 0) isPrime = false;
                }
                if (isPrime)
                    Console.WriteLine(true);
                else
                    Console.WriteLine(false);

            }
        }
        
    }
}
