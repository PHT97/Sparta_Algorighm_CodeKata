using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int divisor)
    {
        List<int> answerList = new List<int>();

        for (int i = 0; i < arr.Length; ++i)
        {
            if (arr[i] % divisor == 0)
            {
                answerList.Add(arr[i]);
            }
        }

        if (answerList.Count == 0)
        {
            answerList.Add(-1);
        }
        else
        {
            // 오름차순 정렬
            answerList.Sort();
        }

        return answerList.ToArray();
    }
}