namespace LeetCodeChallenge9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.IsPalindrome(121));
            Console.WriteLine(Program.IsPalindrome(-121));
            Console.WriteLine(Program.IsPalindrome(10));
        }

        public static bool IsPalindrome(int x)
        {

            if (x < 0)
            {
                return false;
            }
            int size = CalculateSize(x);

            int[] controlArray = new int[size];

            int start = 0;
            int end = size - 1;

            for (int i = size - 1; i >= 0; i--)
            {
                int num = x % 10;
                controlArray[i] = num;
                x /= 10;
            }

            while (start < end)
            {
                if (controlArray[start] != controlArray[end])
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }


        public static int CalculateSize(int x)
        {
            int size = 0;

            do
            {
                size++;
                x /= 10;
            } while (x > 0);

            return size++;

        }


    }
}
