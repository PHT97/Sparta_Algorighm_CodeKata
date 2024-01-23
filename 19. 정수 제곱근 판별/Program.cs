namespace _19._정수_제곱근_판별
{
    internal class Program
    {
        public class Solution
        {
            public long solution(long n)
            {
                long answer = 0;
                for (long i = 1; i <= n; i++)
                {
                    if (i * i == n)
                    {
                        answer = (i + 1) * (i + 1);
                        break;
                    }
                    else if (i * i >= n)
                    {
                        break;
                    }
                }
                if (answer == 0)
                {
                    answer = -1;
                }
                return answer;
            }
        }
    }
}
