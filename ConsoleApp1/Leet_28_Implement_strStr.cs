using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Leet_28_Implement_strStr
    {
        public static void Main(string[] args)
        {
            string haystack = "hello";
            string needle = "ll";
            int output = Leet_28_Implement_strStr.StrStr(haystack, needle);

            Console.WriteLine(output);
            Console.ReadLine();
            
        }

        public static int StrStr(string haystack, string needle)
        {

            if (!haystack.Contains(needle))
                return -1;
            else if (haystack == string.Empty || needle == string.Empty)
                return 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    string temp = haystack.Substring(i, needle.Length);

                    if (temp == needle)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
