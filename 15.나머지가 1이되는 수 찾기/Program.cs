namespace _15.나머지가_1이되는_수_찾기
{
    internal class Program
    {
        public static int solution(int n)
        {
            int answer = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 1)
                {
                    answer = i;
                    break;
                }
            }
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(10));
            Console.WriteLine(solution(12));
        }
    }
}
