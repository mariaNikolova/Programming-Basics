using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double a= double.Parse(Console.ReadLine()) ;
            double b = double.Parse(Console.ReadLine());
            double help;
            if(a>b)
            {
                help=a;
                a = b ;
                b = help;
                
                Console.Write(b + " ");
                Console.WriteLine(a);

            }
            else
            {
                Console.Write(a+ "  ");
                Console.WriteLine(b);
            }
        }
    }
}
