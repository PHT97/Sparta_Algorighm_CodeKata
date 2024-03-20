using System;

public class Solution
{
    public string[] solution(string[] strings, int n)
    {
        string[] answer = new string[] { };

        // Sort 에 간단한 문자의 비교 연산을 추가하여 실행
        Array.Sort(strings, (str1, str2) => {
            // 문자 추출
            var word1 = str1.Substring(n, 1);
            var word2 = str2.Substring(n, 1);

            // 같은 단어면 사전순 정렬, 아니라면 해당 문자 기준으로 비교
            if (word1 == word2)
            {
                return str1.CompareTo(str2);
            }
            else
            {
                return word1.CompareTo(word2);
            }

        });

        answer = strings;

        return answer;
    }
}