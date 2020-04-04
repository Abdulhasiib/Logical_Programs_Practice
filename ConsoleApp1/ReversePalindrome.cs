using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ReversePalindrome
    {
        static void Main(String[] Args)
        {
            string InputString = " ", FirstMatched = "Matched", FirstUnMatched = "UnMatched";
            bool IsMatched = false;
            int i, j;
            Console.WriteLine("Enter string: ");

            InputString = Console.ReadLine();

            char[] String_Array = InputString.ToCharArray();

            for (i = 0; i < String_Array.Length; i++) // i = J
            {
                for (j = 0; j < String_Array.Length; j++) // j = a,v,a
                {
                    if (i != j && String_Array[i] == String_Array[j]  && FirstMatched == "Matched")
                    {
                        FirstMatched = Convert.ToString(String_Array[i]);
                        break;
                    }
                    else if ( j == String_Array.Length - 1 && FirstUnMatched == "UnMatched")
                    {
                        FirstUnMatched = Convert.ToString(String_Array[i]);
                        break;
                    }
                }
                

                if (FirstMatched != "Matched" && FirstUnMatched != "UnMatched")
                {
                    break;
                }
                
            }

            
            Console.WriteLine("First Matched letter is {0}", FirstMatched);
            Console.WriteLine("First UnMatched letter is {0}", FirstUnMatched);
            Console.ReadLine();
        }
    }
}
