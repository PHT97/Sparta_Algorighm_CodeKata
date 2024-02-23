using System;

public class Solution
{
    public int solution(int left, int right)
    {
        int answer = 0;

        //left로 시작하여 right까지 반복문 실행
        for (int i = left; i <= right; i++)
        {
            int count = 0;
            //1부터 i까지 반복문 실행
            for (int j = 1; j <= i; j++)
            {
                //하여 나누었을 때 나머지가 0이면 count 더함.
                if (i % j == 0) count++;
            }
            //반복문 종료 후 카운트를 2로 나눈 나머지가 0이면 
            //짝수이므로 해당 정수 answer에 더하기
            if (count % 2 == 0) answer += i;
            //2로 나눈 나머지가 0이 아니면 해당 정수 answer에 빼기
            else answer -= i;
        }
        return answer;
    }
}