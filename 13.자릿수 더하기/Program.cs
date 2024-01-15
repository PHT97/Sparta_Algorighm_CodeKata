namespace _13.자릿수_더하기
{
    internal class Program
    {

        public static int solution(int n)
        {
            int answer = 0;
            while (n > 0)
            {
                answer += n % 10;
                n = n / 10;
            }
            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(solution(123));
            Console.WriteLine(solution(987));
        }
    }
}
