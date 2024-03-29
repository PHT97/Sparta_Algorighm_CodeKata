using System;

public class Solution
{
    public int[] solution(int k, int[] score)
    {
        int[] answer = new int[score.Length];
        int[] list = new int[k];
        int target;
        int min;
        int temp;

        for (int i = 0; i < list.Length; i++)
        {
            list[i] = -1;
        }

        for (int i = 0; i < score.Length; i++)
        {
            target = score[i];
            min = 9999;
            for (int j = 0; j < list.Length; j++)
            {
                if (list[j] < target)
                {
                    temp = list[j];
                    list[j] = target;
                    target = temp;
                }

                if (list[j] > -1 && min > list[j])
                {
                    min = list[j];
                }
            }
            answer[i] = min;
        }

        return answer;
    }
}