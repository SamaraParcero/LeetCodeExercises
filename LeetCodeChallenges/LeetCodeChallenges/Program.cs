namespace LeetCodeChallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 3, 2, 4 };
            int target = 6;
            Program program = new Program();
            int[] output = program.TwoSum(vetor, target);
            Console.WriteLine($"[{output[0]}, {output[1]}]");

            int[] output2 = program.TwoSum2(vetor, target);
            Console.WriteLine($"[{output2[0]}, {output2[1]}]");
        }


        //Método que fiz:
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target & i !=j)
                    {
                        return new int[] { i, j };
                    }
                }

            }
            return null;
        }

        //Solução O(n) ideal
        public int[] TwoSum2(int[] nums, int target)
        {
            var numMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                {
                    if (numMap.ContainsKey(complement))
                    {
                        return new int[] { numMap[complement], i };
                    }
                }
                numMap[nums[i]] = i;

            }
            return null;
        }

    }
}
