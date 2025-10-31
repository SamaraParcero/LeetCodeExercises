namespace LeetCodeChallenge7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Reverse(123));
            Console.WriteLine(Program.Reverse(123));
            Console.WriteLine(Program.Reverse(120));

        }

        public static int Reverse(int x)
        {
            int reversed = 0;

            while (x != 0)
            {

                int num = x % 10;

                x = x / 10;

                reversed = reversed * 10 + num;

                if (reversed < -2147483648 || reversed > 2147483647)
                {
                    return 0;
                }

            }

            return reversed;

        }
    }
}
