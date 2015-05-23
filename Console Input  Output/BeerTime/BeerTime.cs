using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            TimeSpan timeSpan = new TimeSpan(2, 14, 18);
            Console.WriteLine(timeSpan.ToString());    
        }
    }
}
