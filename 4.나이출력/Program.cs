namespace _4.나이출력
{
    internal class Program
    {
        public static int solution(int age)
        {
            int answer = 0;
            answer = 2022 - age + 1;
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(40));
            Console.WriteLine(solution(23));
        }
    }
}
