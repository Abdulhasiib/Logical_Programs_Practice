using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Palindrome_Number
    {
        static void Main(String[] Args)
        {
            Console.WriteLine("Enter the number: ");

            int Nu = Convert.ToInt32(Console.ReadLine());

            int RevNu = 0;
            int Temp = Nu;
            int FirstNu;

            while(Nu > 0)
            {
                FirstNu = Nu % 10;
                RevNu = RevNu * 10 + FirstNu;
                Nu = Nu / 10;
            }
            Console.WriteLine((Temp == RevNu) ? "Number is Pallindrome" : "Number is not Pallindrome");
            Console.ReadLine();
        }
    }
}
