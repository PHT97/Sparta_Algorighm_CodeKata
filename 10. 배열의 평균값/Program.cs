namespace _10._배열의_평균값
{
    internal class Program
    {
        public static double solution(int[] numbers)
        {
            double answer = 0;
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                answer += numbers[i];
                count++;
            }
            return answer / count;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] numbers = { 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 };
            Console.WriteLine(solution(numbers));
        }
    }
}
