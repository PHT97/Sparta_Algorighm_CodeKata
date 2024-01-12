namespace _12._평균구하기
{
    internal class Program
    {
        public static double solution(int[] arr)
        {
            double answer = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                answer += arr[i];
                count++;
            }
            return answer / count;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 , 4};
            //int[] arr = {5, 5};
            Console.WriteLine(solution(arr));
        }
    }
}
