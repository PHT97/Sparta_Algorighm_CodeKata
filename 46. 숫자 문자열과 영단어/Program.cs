using System;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;

        //string.Replace("해당 문자열을", "해당 문자열로");
        s = s.Replace("zero", "0");
        s = s.Replace("one", "1");
        s = s.Replace("two", "2");
        s = s.Replace("three", "3");
        s = s.Replace("four", "4");
        s = s.Replace("five", "5");
        s = s.Replace("six", "6");
        s = s.Replace("seven", "7");
        s = s.Replace("eight", "8");
        s = s.Replace("nine", "9");

        int k;
        bool strToInt = int.TryParse(s, out k);     //변환 후 해당 문자열이 숫자이면
        if (strToInt) answer = k;                    //answer에 숫자 대입

        return answer;                              //answer 반환
    }
}