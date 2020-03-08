using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsPractice
{
    /// <summary>
    /// Check for letter 'T' in given string and print the word;
    /// if 'T' is at odd position - Reverse word
    /// if 'T' is at even position - same word
    /// if there is no 'T' in word - print 'None'
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            //User prompt
            Console.WriteLine("Enter a string: ");

            //Read string from the user:
            string InputString = Console.ReadLine();
            
            //Split string into words
            string[] WordString = InputString.Split(' ');

            //Loop through each word in string to find letter t and it's position
            foreach (string word in WordString)
            {
                //split words to a char array
                char[] wordArr = word.ToCharArray();

                for (int i = 1; i < wordArr.Length+1; i++)
                {
                    //To avoid 0 parity
                    int j = i - 1; 
                    char letter = wordArr[j];
                    if (letter.Equals('t') || letter.Equals('T'))
                    {
                        if ((i % 2) == 0)
                        {
                            Console.WriteLine(word);
                            break;
                        }
                        else if ((i % 2) != 0)
                        {
                            char[] RevStr = word.ToCharArray();
                            Array.Reverse(RevStr);
                            Console.WriteLine(new string(RevStr));
                            break;
                        }
                    }
                    if (i == wordArr.Length)
                    {
                        Console.WriteLine("None");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
