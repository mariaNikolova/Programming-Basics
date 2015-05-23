using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n] ;
            int start = 0;
            int end = 0;
            int count = 1;
            string help = "";
            for (int j = 0; j <array.Length; j++)
            {
                array[j] = Console.ReadLine();
            }
            int i;
            for ( i = 0; i < array.Length -1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    end++;
                }
                else
                {
                    if ((end - start)  > count)
                    {
                        count = end - start ;
                        help = array[i];
                    }
                    start = end;
                    end = 1;
                }
            }
            if ((end - start) + 1 > count)
            {
                count = end - start + 1;
                help = array[i];
            }
            Console.WriteLine("The longest area in array is : ");
            for (int m = 0; m < count; m++)
            {
                Console.WriteLine(help);
            }
        }
    }
}
