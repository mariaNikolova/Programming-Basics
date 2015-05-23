using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static bool PrimeChecker(int n)
        {
            uint divider = 2;
            uint maxDivider = (uint)Math.Sqrt(n);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (n % divider == 0)
                {
                    prime = false;
                }
                else
                {
                    divider++;
                }

            }

            if (prime)
                return true;
            else
                return false;
        }
        static List<int> FindPrimesInPrime(int startNum, int endNum)
        {
            List<int> newList = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (PrimeChecker(i) && (i !=1 && i!=0))
                {
                    newList.Add(i);
                }
            }

            return newList;
        }
        static void print(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        static void Main(string[] args)
        {
            
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            print(FindPrimesInPrime(start, end));
        }
    }
}
