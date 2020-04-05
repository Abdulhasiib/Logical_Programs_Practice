using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Leet_09_Palindrome
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Number:");
            int InputNumber = Convert.ToInt32(Console.ReadLine());
            bool Result = IsPalindrome(InputNumber);

            if (Result)
            {
                Console.WriteLine("Number {0} is a Palindrome", InputNumber);
            }
            else
            {
                Console.WriteLine("Number {0} is not a Palindrome", InputNumber);
            }
            
            Console.ReadLine();
        }

        public static bool IsPalindrome(int x)
        {

            int temNu;
            int RevNu = 0;
            int Input = x;
            if (x < 0) return false;
            while (x > 0)
            {
                temNu = x % 10;
                RevNu = RevNu * 10 + temNu;
                x = x / 10;
            }

            if (RevNu == Input) return true;
            else return false;
        }
    }
}
