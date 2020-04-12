using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Leet_14_Longest_common_prefix
    {
        public static void Main(String[] args)
        {
            string[] Input = { "dog", "car", "racecar"};

            Console.WriteLine("Longest common prefix is {0}",LongestPrefix(Input));

            Console.ReadLine();
        }

        public static string LongestCommonStr(string[] inputstr)
        {
            string commonprefix = "";
            Dictionary<char, int> strDict = new Dictionary<char, int>();
            
            List<char> strList = new List<char>();

            foreach (string item in inputstr)
            {
                for (int i = 0; i < item.Length; i++)
                {

                    //if (i > strList.Count) break;
                    if (strDict.ContainsKey(item[i]) && strList[i] == item[i])
                    {

                        strDict[item[i]] = strDict[item[i]] + 1;
                    }
                    else
                    {
                        if(!strList.Contains(item[i]))
                        strList.Add(item[i]);
                        if(!strDict.ContainsKey(item[i]))
                            strDict.Add(item[i], 1);
                    }
                }
            }

            int CommonCount = strDict.Count(value => value.Value == inputstr.Length);
            foreach(KeyValuePair<char,int> KeyValue in strDict)
            {
                if (KeyValue.Value >= inputstr.Length)
                {
                    commonprefix = commonprefix + KeyValue.Key;
                }
            }
            
            return commonprefix;
        }

        public static string LongestPrefix(string[] strs)
        {

            if (strs.Length == 0 || strs == null) return "";
            else if (strs.Length == 1) return strs[0];

            Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));

            string prefix = strs[0];
            
            for (int j = 1; j < strs.Length; j++)
            {
                for (int k = 0; k < strs[j].Length; k++) 
                {
                    if ((k < prefix.Length) && (strs[j].ElementAt(k) != strs[0].ElementAt(k)))
                    {
                        prefix = prefix.Remove(k);
                        if (j < strs.Length) break;
                        else return prefix;
                    } 
                }
            }

            return prefix;

            
        }
    }
}
