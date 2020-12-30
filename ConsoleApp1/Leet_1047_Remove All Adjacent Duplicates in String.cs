using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Leet_1047_Remove_All_Adjacent_Duplicates_in_String
    {
        public static void Main(string[] Args)
        {
            Console.WriteLine("Enter input string: ");

            string inputstr = Console.ReadLine();
            bool duplicate;
            do
            {
                duplicate = false;

                for (int i=0; i<inputstr.Length-1; i++)
                {
                    if(inputstr[i] == inputstr[i + 1])
                    {
                        inputstr = inputstr.Remove(i,2);
                        duplicate = true;
                    }
                }
                
            } while (duplicate == true);

            Console.WriteLine(inputstr);
            Console.ReadLine();

        }
    }
}
