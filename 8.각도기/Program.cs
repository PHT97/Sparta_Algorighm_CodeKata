namespace _8.각도기
{
    internal class Program
    {
        public static int solution(int angle)
        {
            if (angle > 0 && angle < 90)
            {
                return 1;
            }
            else if (angle == 90)
            {
                return 2;
            }
            else if (angle > 90 && angle < 180)
            {
                return 3;
            }
            else if (angle == 180)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(70));
            Console.WriteLine(solution(91));
            Console.WriteLine(solution(180));
        }
    }
}
