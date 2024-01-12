namespace _11._짝수와_홀수
{
    internal class Program
    {
        public static string solution(int num)
        {
            string answer = "";
            if (num % 2 == 0)
            {
                answer = "Even";
            }
            else
            {
                answer = "Odd";
            }
            return answer;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(solution(3));
            Console.WriteLine(solution(4));
        }
    }
}
