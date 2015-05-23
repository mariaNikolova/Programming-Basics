using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if(a>=b && a>=c)
            {
                if(b>c)
                {
                    Console.WriteLine(a + " " + b +" " + c);
                }
                if(c>b)
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
            }
            else if(b>=a && b>=c)
            {
                if(a>c)
                {
                    Console.WriteLine(b + " " + a +" " + c);
                }
                if(c>a)
                {
                    Console.WriteLine(b + " " + c +" " + a);
                }
            }
            else if(c>=a && c>=b)
            {
                if(a>b)
                {
                    Console.WriteLine(c + " " + a +" " + b);
                }
                if(b>a)
                {
                    Console.WriteLine(c + " " + b +" " + a) ;
                }
            }
            else if(a == b)
            {
                if(a>c)
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
                if(a<c)
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
            }
            else if(a == c)
            {
                if(a>b)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
                if(a<b)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
            }
            else if(b==c)
            {
                if(b>a)
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
                if(b<a)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
            }
        }
    }
}
