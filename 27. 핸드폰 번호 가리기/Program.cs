namespace _27._핸드폰_번호_가리기
{
    internal class Program
    {
        public class Solution
        {
            public string solution(string phone_number)
            {
                string answer = "";
                for (int i = 0; i < phone_number.Length; i++)
                {
                    if (i < phone_number.Length - 4)
                        answer += "*";
                    else
                        answer += phone_number[i];
                }
                return answer;
            }
        }
    }
}
