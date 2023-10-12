using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr)
    {
        int[] answer = arr;
        int indexNum = Array.IndexOf(arr, arr.Min());

        if (arr.Length == 1)
        {
            answer[0] = -1;
        }
        else
        {
            for (int i = indexNum; i < arr.Length -1; i++)
            {
                arr[i] = arr[i + 1];
            }

            Array.Resize(ref answer, answer.Length - 1);
        }
        return answer;
    }
}