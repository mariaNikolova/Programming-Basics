using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtDigitIs7
{
    class TrirtDigitIs7
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = number / 100; 
            if(result % 10 == 7 )
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
