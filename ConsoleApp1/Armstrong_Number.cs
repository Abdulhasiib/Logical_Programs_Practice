using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Armstrong_Number
    {
        static void Main(String[] Args)
        {
            Console.WriteLine("Enter Number: ");

            int Number = Convert.ToInt32(Console.ReadLine().Trim());

            int Sum = 0; int vNumber = Number;

            while(vNumber > 0)
            {
                int Digit = vNumber % 10;
                Sum = Sum + Digit * Digit * Digit;
                vNumber = vNumber / 10;
            }

            Console.WriteLine((Sum == Number) ? "Number is Armstrong" : "Number is not Armstrong");
            Console.ReadLine();
        }
    }
}
