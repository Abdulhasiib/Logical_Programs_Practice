using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Leet_1047_Remove_All_Adjacent_Duplicates_Stack
    {
        public static void Main(string[] Args)
        {
            Console.WriteLine("Enter input string: ");
            string inputstr = Console.ReadLine();
            
            Stack<char> temp = new Stack<char>();
            
            string output = "";
            for (int i = 0; i < inputstr.Length; i++)
            {
                if (temp.Count>0 && temp.Peek() == inputstr[i])
                {
                    temp.Pop();
                }
                else
                {
                    temp.Push(inputstr[i]);
                }
                
            }
            foreach(char letter in temp)
            {
                output = letter + output;
            }
            
            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}
