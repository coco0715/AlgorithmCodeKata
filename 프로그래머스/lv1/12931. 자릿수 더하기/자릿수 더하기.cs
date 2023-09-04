using System;

public class Solution {
     public int solution(int n) {
        int answer = 0;
        
        char[] arr = n.ToString().ToCharArray();
        
        foreach(char a in arr)
        {
            answer += System.Convert.ToInt32(a.ToString());
        }
        return answer;
    }
}