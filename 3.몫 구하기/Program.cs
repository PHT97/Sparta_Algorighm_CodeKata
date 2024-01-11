namespace _3.몫_구하기
{
    internal class Program
    {
        public static int solution(int num1, int num2)
        {
            int answer = 0;
            answer = num1 / num2;
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(10,5));
            Console.WriteLine(solution(7,2));
        }
    }
}
