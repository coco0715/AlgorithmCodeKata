using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(long n)
    {
        string strN = n.ToString();
        char[] charArr = strN.ToCharArray();
        string[] strArr = new string[charArr.Length];

        Array.Sort(charArr);
        Array.Reverse(charArr);
  
        for (int i = 0; i < charArr.Length; i++)
        {
            strArr[i] = charArr[i].ToString();
        }

        int[] answer = Array.ConvertAll(strArr, a => int.Parse(a));

        return answer;
    }
}