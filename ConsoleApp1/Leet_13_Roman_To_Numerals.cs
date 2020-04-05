using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Leet_13_Roman_To_Numerals
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Number in Roman:");
            string RomanNumber = Console.ReadLine();

            Console.WriteLine("Roman number {0} is written as {1} in Numerals", RomanNumber, RomanToint(RomanNumber));
            Console.ReadLine();
        }

        public static int RomanToint(string s)
        {
            int Digit = 0;
            int Numeral = 0;

            char[] charArray = s.ToCharArray();

            Dictionary<char, int> dictRomans = new Dictionary<char, int>();

            dictRomans.Add('I', 1);
            dictRomans.Add('V', 5);
            dictRomans.Add('X', 10);
            dictRomans.Add('L', 50);
            dictRomans.Add('C', 100);
            dictRomans.Add('D', 500);
            dictRomans.Add('M', 1000);

            for (int i = 0; i < charArray.Length; i++)
            {
                if ((charArray[i] == 'I') && (i != charArray.Length-1) && ((charArray[i+1] == 'V') || ( charArray[i+1] == 'X')))
                {
                    Digit = dictRomans[charArray[i+1]] - 1;
                    i = i + 1;
                }
                else if ((charArray[i] == 'X') && (i != charArray.Length - 1) && ((charArray[i + 1] == 'L') || (charArray[i + 1] == 'C')))
                {
                    Digit = dictRomans[charArray[i + 1]] - 10;
                    i = i + 1;
                }

                else if ((charArray[i] == 'C') && (i != charArray.Length - 1) && ((charArray[i + 1] == 'D') || (charArray[i + 1] == 'M')))
                {
                    Digit = dictRomans[charArray[i + 1]] - 100;
                    i = i + 1;
                }
                else
                {
                    Digit = dictRomans[charArray[i]];
                }
                Numeral = Numeral + Digit;
            }
            return Numeral;
        }
    }
}
