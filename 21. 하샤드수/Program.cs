namespace _21._하샤드수
{
    internal class Program
    {
        public class Solution
        {
            public bool solution(int x)
            {
                bool answer = false;
                int originX = x;
                int sum = 0;
                while (x > 0)
                {
                    sum += x % 10;
                    x = x / 10;
                }
                if (originX % sum == 0)
                {
                    answer = true;
                }
                return answer;
            }
        }
    }
}
