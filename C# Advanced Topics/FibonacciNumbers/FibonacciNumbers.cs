using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void fib(int n)
        {
            int first = 1;
            int second = 1;
            int thirt;
            for (int i = 2; i <= n; i++)
            {
                thirt = first + second;
                first = second;
                second = thirt;
            }
            Console.WriteLine(second);

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            fib(n);
        }
    }
}
