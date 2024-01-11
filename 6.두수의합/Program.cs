namespace _6.두수의합
{
    internal class Program
    {
        public static int solution(int num1, int num2)
        {
            int answer = 0;
            answer = num1 + num2;
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(2,3));
            Console.WriteLine(solution(100, 2));
        }
    }
}
