namespace _9.짝수의_합
{
    internal class Program
    {
        public static int solution(int n)
        {
            int result = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(10));
            Console.WriteLine(solution(4));
        }
    }
}
