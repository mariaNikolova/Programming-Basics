using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, m];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m ; col++)
                {
                    matrix[row, col] = "" + (char)('a' + row) + (char)('a' + col) + (char)('a'+row);
                }
            }



            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col] + "  ");
                }
                Console.WriteLine();
            }

        }
    }
}
