using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class WeightOnTheMoon
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double result = weight * 0.17;
            Console.WriteLine(result);
        }
    }
}
