using System;

public class Solution {
    public int solution(int[] numbers)
    {
        int answer = 0;
        int exist = 0;
      
        for (int i = 0; i <= 9; i++)
        {
          if(-1 == (exist = Array.IndexOf(numbers, i)))
            {
                answer += i;
            }
        }
        return answer;
    }
}