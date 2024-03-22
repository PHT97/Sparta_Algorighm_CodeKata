using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        int[] answer = new int[] { };

        List<int> list = new List<int>();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                list.Add(numbers[i] + numbers[j]);
            }
        }
        //list 오름차순 Sort() 정렬
        list.Sort();

        //Distinct().ToArray() 중복 삭제
        answer = list.Distinct().ToArray();

        return answer;
    }
}