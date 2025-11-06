using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenge20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.IsValid("()"));
            Console.WriteLine(Program.IsValid("()[]{}"));
            Console.WriteLine(Program.IsValid("(]"));
            Console.WriteLine(Program.IsValid("([])"));
            Console.WriteLine(Program.IsValid("([)]"));
        }

        public static bool IsValid(string s)
        {

            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> charPair = new Dictionary<char, char>() {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

            foreach (char sb in s)
            {
                if (charPair.ContainsValue(sb))
                {
                    stack.Push(sb);
                }
                else if (charPair.ContainsKey(sb))
                {
                    if (stack.Pop() != charPair[sb])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0 ? true : false;

        }
    }
}
