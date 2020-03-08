using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Output_a_text_based_on_even_odd
    {
        static void Main(String[] args)
        {
            //User Input for maximum number
            Console.WriteLine("Enter Maximum number: ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string state = "";

            for (int i = 1; i < n + 1; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                {
                    state = "FizzBuzz";
                }
                else if ((i % 3) == 0 && (i % 5) != 0)
                {
                    state = "Fizz";
                }
                else if ((i % 5) == 0 && (i % 3) != 0)
                {
                    state = "Buzz";
                }
                else
                {
                    state = "number";
                }

                switch (state)
                {
                    case "number":
                        Console.WriteLine(i);
                        break;

                    case "Fizz":
                        Console.WriteLine("Fizz");
                        break;

                    case "Buzz":
                        Console.WriteLine("Buzz");
                        break;

                    case "FizzBuzz":
                        Console.WriteLine("FizzBuzz");
                        break;
                }

            }
            Console.ReadLine();
        }
    }
}
