using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FindFirstRepeatedAndNonRepeated
    {
        static void Main(String[] Args)
        {
            Console.WriteLine("Enter input string:");

            string InputString = Console.ReadLine();
            char[] repeatChar = FindRepeatAndNonRepeat(InputString);

            Console.WriteLine("First Repeated character is {0} and Non Repeat is {1}", repeatChar[1], repeatChar[0]);
            Console.ReadLine();
        }


        public static char[] FindRepeatAndNonRepeat(string Sentence)
        {
            //Char Array to store result characters
            char[] result = new char[2];

            //Dictionary with Character is Key and Count as Value
            Dictionary<char, int> SentDict = new Dictionary<char, int>();

            //Convert given string to character array
            char[] CharArray = Sentence.ToLower().ToCharArray();

            foreach (char letter in CharArray)
            {
                if (SentDict.ContainsKey(letter))
                {
                    //increament count if character is present in Dictionary
                    SentDict[letter] = SentDict[letter] + 1;
                }
                else    
                {
                    //Add Unique character to Dictionary
                    SentDict.Add(letter, 1);
                }
            }

            //Condition if no repeat character or no non repeat character
            int RepeatedCount = SentDict.Count(value => value.Value > 1);

            if (!SentDict.ContainsValue(1))
            {
                Console.WriteLine("String does not contain non repeat character");
            }
            else if (RepeatedCount == 0)
            {
                Console.WriteLine("String does not contain repeat character");
            }

            //Find first non repeated character
            foreach (char let in CharArray)
            {
                if (SentDict[let] == 1)
                {
                    result[0] = let;
                    break;
                }
            }

            //Find first repeated character
            foreach (char lett in CharArray)
            {
                if (SentDict[lett] > 1)
                {
                    result[1] = lett;
                    break;
                }
            }

            return result;
            
        }

       
    }
}
