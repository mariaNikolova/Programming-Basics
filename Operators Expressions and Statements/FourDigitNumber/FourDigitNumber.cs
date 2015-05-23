using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                number = int.Parse(Console.ReadLine());

            } while (number < 1000 || number > 9999);
            int num1 = number;
            int num2 = number;
            int num3 = number ;
            int sum = 0;
            int help= 0 ;
            while (number != 0)
            {
                help = number % 10;
                number = number / 10;
                sum = sum + help;

            }
            Console.WriteLine("The sum is: {0}",sum);
            Console.Write("The reverse number is: ");
            while(num1!=0)
            {
                help = num1 % 10;
                Console.Write(help);
                num1 = num1 / 10;
            }
            Console.WriteLine("");
            int lastDigit = num2 % 10;
            num2 = num2 / 10;
            Console.WriteLine("The last digit in the first position {0}{1}",lastDigit,num2);

            int thirdDigit = (num3 / 10) % 10;
            int secondDigit = (num3/100)%10 ;
          int fourthDigit = num3%10 ;
          num3 = num3 / 1000;
            Console.WriteLine("The third digit on the second position is {0}{1}{2}{3}", num3, thirdDigit,secondDigit, fourthDigit);
        }
    }
}
