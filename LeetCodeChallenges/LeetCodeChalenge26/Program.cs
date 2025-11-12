using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChalenge26
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int k = 1;


            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
}
