using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenge13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.RomanToInt("III"));
            Console.WriteLine(Program.RomanToInt("LVIII"));
            Console.WriteLine(Program.RomanToInt("MCMXCIV"));
        }

        public static int RomanToInt(string s)
        {
            var romanNumbers = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            int sum = 0;
            int beforeValue = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                char caractere = s[i];
                int value = romanNumbers[caractere];
                if (value < beforeValue)
                {
                    sum -= value;
                }
                else
                {
                    sum += value;
                }
                beforeValue = value;
            }

            return sum;


        }
    }

   

    }
