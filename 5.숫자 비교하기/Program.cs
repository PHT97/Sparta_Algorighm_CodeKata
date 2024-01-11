namespace _5.숫자_비교하기
{
    internal class Program
    {
        public static int solution(int num1, int num2)
        {
            if (num1 == num2)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(2,3));
            Console.WriteLine(solution(11, 11));
            Console.WriteLine(solution(7, 99));
        }
    }
}
