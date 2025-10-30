namespace LeetCodeChallenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Program.LengthOfLongestSubstring("abcabcbb");
            var result2 = Program.LengthOfLongestSubstring("bbbbb");
            var result3 = Program.LengthOfLongestSubstring("pwwkew");

            Console.WriteLine("Result 1: " + result);
            Console.WriteLine("Result 2: " + result2);
            Console.WriteLine("Result 3: " + result3);
        }

        public static int LengthOfLongestSubstring(string s)
        {

            int count = 0;
            string strings = "";

            foreach (char sb in s)
            {
                if (strings.Contains(sb))
                {
                    int index = strings.IndexOf(sb);
                    strings = strings.Substring(index + 1);
                }

                strings += sb;
                if (count < strings.Length)
                {
                    count = strings.Length;
                }
            }

            return count;

        }
    }
}
