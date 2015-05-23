using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfNames = new List<string>();
            string[] firstList = Console.ReadLine().Split(' ');
            string[] secondList = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < firstList.Length; i++)
            {
                listOfNames.Add(firstList[i]);
                for (int j = 0; j < secondList.Length; j++)
                {
                    if (firstList[i] == secondList[j])
                    {
                        listOfNames.Remove(firstList[i]);
                    }
                }

            }
            foreach (var name in listOfNames)
            {
                Console.WriteLine(name + " ");
            }
            Console.WriteLine();
    
        }
    }
}
