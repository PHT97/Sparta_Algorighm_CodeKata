﻿using System;
using System.Linq;

public class Solution
{
    public string solution(string s)
    {
        char[] temp = s.ToCharArray();
        Array.Sort(temp);
        Array.Reverse(temp);

        return new string(temp);
    }
}