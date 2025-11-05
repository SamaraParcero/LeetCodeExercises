using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenge14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
            Console.WriteLine(Program.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string prefix = strs[0];


            for (int i = 1; i < strs.Length; i++)
            {

                string actual = strs[i];
                string newPrefix = "";

                int minSize = Math.Min(prefix.Length, actual.Length);

                for (int j = 0; j < minSize; j++)
                {
                    if (prefix[j] == actual[j])
                    {
                        newPrefix += prefix[j];
                    }
                    else
                    {
                        break;
                    }
                }

                prefix = newPrefix;

            }

            return prefix;
        }
    }
}
