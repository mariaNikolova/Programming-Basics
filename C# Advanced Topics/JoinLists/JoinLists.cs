using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            List<string> listOfNumbers = new List<string>();
            string[] first = Console.ReadLine().Split(' ') ;
            string[] second = Console.ReadLine().Split(' ');

            for (int i = 0; i < first.Length; i++)
            
            {
                listOfNumbers.Add(first[i]);
                for (int j = 0; j < second.Length; j++)
                {
                    listOfNumbers.Add(second[j]);

                    if (first[i] == second[j])
                    {
                        listOfNumbers.Remove(second[j]);
                        //listOfNumbers.Sort();

                    }
                }

            }
            listOfNumbers.Sort();
            foreach (var name in listOfNumbers)
            {
                Console.WriteLine(name + " ");
            }
            Console.WriteLine();

        }
    }
}
