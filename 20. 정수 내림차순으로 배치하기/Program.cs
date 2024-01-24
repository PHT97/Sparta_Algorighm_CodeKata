namespace _20._정수_내림차순으로_배치하기
{
    internal class Program
    {
        public class Solution
        {
            public long solution(long n)
            {
                long answer = 0;
                //long형식으로 Char배열을 입력하고 입력된문자를 Sort로 오름차순으로 정렬한 다음 Reverse로 뒤집음
                char[] a = n.ToString().ToCharArray();
                System.Array.Sort(a);
                System.Array.Reverse(a);
                answer = System.Convert.ToInt64(new string(a));
                return answer;
            }
        }
    }
}
