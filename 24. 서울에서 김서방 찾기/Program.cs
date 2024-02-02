namespace _24._서울에서_김서방_찾기
{
    public class Solution
    {
        public string solution(string[] seoul)
        {
            string answer = "";
            for (int i = 0; i < seoul.Length; i++)
            {
                if (seoul[i] == "Kim")
                {
                    answer = "김서방은 " + i + "에 있다";
                    break;
                }
            }
            return answer;
        }
    }
}
