namespace _2._두수의_곱
{
    internal class Program
    {
        public static int solution(int num1, int num2)
        {
            int answer = 0;
            answer = num1 * num2;
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(3, 4));
            Console.WriteLine(solution(27, 19));
        }
    }
}
