using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Given_Number_in_Given_Array
    {
        static void Main(String[] args)
        {
            //User Input number:
            Console.WriteLine("Enter the number: ");
            int GivenNumber = Convert.ToInt32(Console.ReadLine().Trim());

            //User Input size of Array
            Console.WriteLine("Enter the count of List: ");

            int Count = Convert.ToInt32(Console.ReadLine().Trim());


            List<int> intList = new List<int>();

            Console.WriteLine("Enter the numbers List:");

            //Add Numbers to the List:
            for (int i = 0; i < Count; i++)
            {
                int Nu = Convert.ToInt32(Console.ReadLine().Trim());
                intList.Add(Nu);
            }

            string Result = "";
            foreach (int a in intList)
            {
                if (a == GivenNumber)
                {
                    Console.WriteLine("Given number {0} is available in given List.", GivenNumber);
                    Result = "Number Found";
                    break;
                }

            }

            if (Result == "")
            {
                Console.WriteLine("Given Number {0} not found in given List.", GivenNumber);
            }
            Console.ReadLine();
        }
    }
}
