using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenge27
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public class Solution
        {
            public int RemoveElement(int[] nums, int val)
            {
                int cont = 0;


                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == val && (i + 1) < nums.Length)
                    {
                        nums[i] = nums[i + 1];
                    }
                    else if (nums[i] != val)
                    {
                        cont++;
                    }
                }

                return cont;

            }
        }
    }
}
