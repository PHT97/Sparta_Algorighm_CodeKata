using System.ComponentModel.Design;

namespace _14._약수의_합
{
    internal class Program
    {
        public static int solution(int n)
        {
            int answer = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    answer += i;
                }
            }
            return answer + n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(12));
            Console.WriteLine(solution(5));
        }
    }
}
