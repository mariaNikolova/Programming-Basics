using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double raduis = 2.0;

            if(x*x + y*y <= raduis*raduis)
            {
                Console.WriteLine(true);
            }
           
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
