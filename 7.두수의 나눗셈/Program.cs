namespace _7.두수의_나눗셈
{
    internal class Program
    {
        public static int solution(int num1, int num2)
        {
            int answer = 0;
            answer = (int)((float)num1 / (float)num2 * 1000);
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(3,2));
            Console.WriteLine(solution(7, 3));
            Console.WriteLine(solution(1, 16));
        }
    }
}
