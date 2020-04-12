using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Leet_20_Valid_Parentheses
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(IsValid("{[]}"));
            Console.ReadLine();
        }

        public static bool IsValid(string s)
        {
            if ((s.Length % 2) != 0) return false;
            else if (String.IsNullOrEmpty(s)) return true;

            Dictionary<char, char> parenDict = new Dictionary<char, char>();

            parenDict.Add('(', ')');
            parenDict.Add('[', ']');
            parenDict.Add('{', '}');

            Stack<char> parenStack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (parenStack.Count == 0)
                {
                    if (parenDict.ContainsKey(s[i]))
                    {
                        parenStack.Push(s[i]);
                    }
                    else return false;
                }
                else
                {
                    char parenthesis = parenStack.Peek();

                    if (s[i] == parenDict[parenthesis])
                    {
                        parenStack.Pop();
                    }
                    else
                    {
                        if (parenDict.ContainsKey(s[i]))
                        {
                            parenStack.Push(s[i]);
                        }
                        else return false;
                    }
                }
            }

            return (parenStack.Count == 0); 
        }
    }
}
