using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleOrString
{
    class IntDoubleOrString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plaese choose your type");
            Console.WriteLine("1-->int");
            Console.WriteLine("2-->double");
            Console.WriteLine("3-->string");
            string number = Console.ReadLine();
            switch(number)
            {
                case "1": Console.WriteLine("Please enter a int");
                    int numberOne = int.Parse(Console.ReadLine());
                    number = number + 1;
                    Console.WriteLine(number); break;
                case "2": Console.WriteLine("Please ednter a double");
                    double numberTwo = double.Parse(Console.ReadLine());
                    numberTwo = numberTwo + 1;
                    Console.WriteLine(numberTwo); break ;
                case "3": Console.WriteLine("Please enter a string");
                    string word = Console.ReadLine();
                    Console.WriteLine(word + "*"); break ;
                default: Console.WriteLine("Error! "); break;

            }
            
        }
    }
}
