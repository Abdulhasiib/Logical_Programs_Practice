using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Leet_1209_Remove_All_Adjacent_Duplicates_String_II
    {
        public static void Main(string[] Args)
        {
            string s = "deeedbbcccbdaa";
            string output = "";
            int k = 3;

            
            Stack<char> charstack = new Stack<char>();
            Stack<int> intstack = new Stack<int>();

            foreach(char letter in s)
            {
                if(charstack.Count > 0 && charstack.Peek() == letter)
                {
                        intstack.Push(intstack.Peek() +1);
                }
                else
                {
                    intstack.Push(1);
                }

                charstack.Push(letter);

                if(intstack.Peek() == k)
                {
                    for (int i = 0; i < k; i++)
                    {
                        charstack.Pop();
                        intstack.Pop();
                    }
                    
                }
            }
            
            foreach(char remletter in charstack)
            {
                output = remletter + output;
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
