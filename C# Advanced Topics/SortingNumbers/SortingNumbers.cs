using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumbers
{
    class SortingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) ;
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Console.WriteLine("The sort sequence is : ");
            for (int i = 0; i < numbers.Length; i++)
            {
                
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
