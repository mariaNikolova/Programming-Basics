using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBit3
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 3;
            int n = int.Parse(Console.ReadLine());
            int nRightP = n >> p;
            int bit = nRightP & 1;
            Console.WriteLine(bit);
        }
    }
}
