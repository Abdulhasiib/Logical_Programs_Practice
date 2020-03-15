using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pallindrome_String
    {
        static void Main(String[] Args)
        {
            Console.WriteLine("Enter String: ");

            string InputString = Console.ReadLine();

            int min = 0;
            int max = InputString.Length - 1;
            bool flag = true;

            while (flag)
            {
                if (min > max)
                {
                    Console.WriteLine("String {0} is Palindrome.", InputString);
                    break;
                }
                char a = InputString[min];
                char b = InputString[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    Console.WriteLine("String {0} is not Palindrome.", InputString);
                    flag = false;
                }
                min++;
                max--;

            }

            Console.ReadLine();
        }
    }
}
