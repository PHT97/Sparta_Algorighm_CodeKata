namespace _17._자연수_뒤집어_배열로만들기
{
    internal class Program
    {
        public static int[] solution(long n)
        {
            string a = n.ToString();
            int[] answer = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                answer[i] = (int)(n % 10);
                n = n / 10;
            }
            return answer;
        }
    }
}
