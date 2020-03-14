using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CheckAnagram
    {
        static void Main(String[] Args)
        {
            Console.WriteLine("Enter first sentence: ");
            string FirstString = Console.ReadLine().Trim();

            Console.WriteLine("Enter second sentence: ");
            string SecondString = Console.ReadLine().Trim();

            char[] StringF = FirstString.ToLower().ToCharArray();

            char[] StringS = SecondString.ToLower().ToCharArray();

            Array.Sort(StringF);
            Array.Sort(StringS);

            string FinalStr1 = new string(StringF);
            string FinalStr2 = new string(StringS);


            Console.WriteLine((FinalStr1 == FinalStr2) ? "Sentences are Anagram" : "Sentences are not Anagram");
            Console.ReadLine();
            
        }
    }
}
