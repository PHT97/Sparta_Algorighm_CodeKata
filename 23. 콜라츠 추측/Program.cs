namespace _23._콜라츠_추측
{
    public class Solution
    {
        public int solution(int num)
        {
            int answer = 0;
            long n = num;
            if (n == 1) return 0;
            for (int i = 0; i < 500; i++)
            {
                answer++;
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = n * 3 + 1;
                }
                if (n == 1)
                {
                    return answer;
                }
            }
            answer = -1;
            return answer;
        }
    }
}
