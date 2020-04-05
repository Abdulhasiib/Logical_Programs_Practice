using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Leet_07_Reverse_Integer
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Number: ");
            int InputNu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Reverse Number is {0}", Reverse(InputNu));
            Console.ReadLine();
        }

        public static int Reverse(int x)
        {
            int tempNu;
            int RevNu = 0;

            while (x != 0)
            {
                tempNu = x % 10;
                if (RevNu > int.MaxValue / 10 || (RevNu == int.MaxValue / 10 && tempNu > 7))
                    return 0;

                if (RevNu < int.MinValue / 10 || (RevNu == int.MinValue / 10 && tempNu < -8))
                    return 0;
                RevNu = RevNu * 10 + tempNu;
                x = x / 10;
            }

            return RevNu;
        }
    }
}
