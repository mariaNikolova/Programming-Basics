using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double help;
            if (a > b)
            {
                help = a;
                a = b;
                b = help;

                Console.Write(a + " ");
                Console.WriteLine(b);

            }
            else
            {
                Console.Write(a + "  ");
                Console.WriteLine(b);
            }
        }
    }
}
