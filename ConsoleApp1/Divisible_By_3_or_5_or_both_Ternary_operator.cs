using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Divisible_By_3_or_5_or_both_Ternary_operator
    {
        static void Main(String[] Args)
        {
            Console.WriteLine("Enter Maximum Number");

            int MaxNumber = Convert.ToInt32(Console.ReadLine().Trim());

            for(int i = 1; i <= MaxNumber; i++)
            {
                string Result = ((i % 3 == 0) && (i % 5 == 0)) ? "FizzBuzz" : (i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : i.ToString();

                Console.WriteLine(Result);
            }
            Console.ReadLine();
        }
    }
}
