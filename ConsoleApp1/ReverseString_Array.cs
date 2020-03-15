using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ReverseString_Array
    {
        static void Main()
        {
            Console.WriteLine("Enter String: ");
            string InputString = Console.ReadLine();

            string RevString = ""; 

            for (int i = InputString.Length-1; i >= 0; i--)
            {
                RevString = RevString + InputString[i];

            }
            Console.WriteLine("Reverse String of string {0} is {1}", InputString, RevString);
            Console.ReadLine();
        }
    }
}
