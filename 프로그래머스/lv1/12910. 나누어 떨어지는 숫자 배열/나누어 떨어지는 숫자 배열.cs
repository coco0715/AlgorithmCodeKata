using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor)
    {
        List<int> result = new List<int>();
        foreach(int i in arr)
        {
            if (i % divisor == 0)
            {
                result.Add(i);
            }
        }

        if (result.Count == 0)
        {
            result.Add(-1);
        }

        int[] answer = new int[result.Count];
        int count = 0;

        foreach (int j in result)
        {
            answer[count] = j;
            count++;
        }

        Array.Sort(answer);

        return answer;
    }
}