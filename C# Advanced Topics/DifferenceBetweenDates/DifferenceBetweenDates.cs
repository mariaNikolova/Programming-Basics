using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            DateTime firstData = DateTime.Parse(Console.ReadLine());
            DateTime secondData = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Razlikata e: {0}", firstData - secondData); 
        }
    }
}
