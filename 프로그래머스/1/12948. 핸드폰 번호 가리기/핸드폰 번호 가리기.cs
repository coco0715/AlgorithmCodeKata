using System;
using System.Text;

public class Solution {
     public string solution(string phone_number)
     {
        string answer = phone_number;
        int stringSize = phone_number.Length;
        int lastChangeNum = stringSize - 4;
        char protectionMark = '*';

        StringBuilder sb = new StringBuilder(phone_number);
     
         for (int i = 0; i < lastChangeNum; i++)
         {
            sb[i] = protectionMark;
            answer = sb.ToString();
         }
         return answer;
     }
}