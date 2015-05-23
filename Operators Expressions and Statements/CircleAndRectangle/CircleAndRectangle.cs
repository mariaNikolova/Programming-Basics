using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAndRectangle
{
    class CircleAndRectangle
    {
        static void Main(string[] args)
        {
            double raduis = 1.5;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool isInRectangle = (x <= 5 && x >= -1 && y >= -1 && y <= 1);
            if(( ((x-1)*(x-1)) + ((y-1)*(y-1)) <= raduis * raduis ) && isInRectangle != true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
