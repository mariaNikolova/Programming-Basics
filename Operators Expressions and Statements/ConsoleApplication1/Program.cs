﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 != 0)
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
