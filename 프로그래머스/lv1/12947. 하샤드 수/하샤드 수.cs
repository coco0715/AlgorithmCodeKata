using System;
public class Solution {
    public bool solution(int inputNum)
    {
        bool answer = false;
        int total = 0;

        char[] cNum = inputNum.ToString().ToCharArray();

        foreach (char c in cNum) 
        {
            total += Int32.Parse(c.ToString());
        }

        if (inputNum % total == 0)
        {
            answer = true;
        }
        return answer;
    }
}
