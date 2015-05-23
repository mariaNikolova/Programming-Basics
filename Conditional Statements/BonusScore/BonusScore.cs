using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if(number >= 1 && number <=3)
            {
                number = number * 10;
                Console.WriteLine(number);
            }
            else if(number >=4 && number <=6)
            {
                number = number * 100;
                Console.WriteLine(number);
            }
            else  if(number >= 7 && number<=9)
            {
                number = number * 1000;
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
        }
    }
}
