using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Start_Pyramid
    {
        static void Main(String[] Args)
        {
            int i, j, k, n;
            Console.WriteLine("Enter number of rows of pyramid:");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <=n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= 2*i-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
