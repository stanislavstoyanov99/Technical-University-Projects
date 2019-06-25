using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "G.,.eorge.,";
            char[] chars = new char[] { '.', ',', ':' };

            Console.WriteLine(input.ClearString(chars));
            Console.WriteLine(input.ClearString(".,:"));
        }
    }

    public static class ExtensionString
    {
        public static string ClearString (this string s, char[] chars)
        {
            var sb = new StringBuilder();
            List<char> charList = new List<char>(chars);

            for (int i = 0; i < s.Length; i++)
            {
                if (!charList.Contains(s[i]))
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }

        public static string ClearString(this string s, string secondString)
        {
            var charArray = secondString.ToCharArray();
            return ClearString(s, charArray);
        }
    }
}
