namespace LeetCodeChallenge5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.LongestPalindrome("babad"));
            Console.WriteLine(Program.LongestPalindrome("cbbd"));
        }


        public static string LongestPalindrome(string s)
        {

            string longest = "";

            for (int i = 0; i < s.Length; i++)
            {
                string sb = expand(s, i, i);

                if (sb.Length > longest.Length)
                {
                    longest = sb;
                }

                string sb2 = expand(s, i, i + 1);
                if (sb2.Length > longest.Length)
                {
                    longest = sb2;
                }
            }

            return longest;
        }

        private static string expand(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return s.Substring(left + 1, right - left - 1);

        }
    }
}
