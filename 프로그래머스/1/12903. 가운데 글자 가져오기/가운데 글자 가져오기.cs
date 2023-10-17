using System.Text;

public class Solution {
    public string solution(string s)
    {
        string answer = ""; //만환 할 문자열
        int sLength = s.Length; // 문자열 전체 길이
        int middleIndex = 0; // 중간 글자 첫번째 인덱스 번호
        int cutLength = 0;

        StringBuilder sb = new StringBuilder(s);
    
        // 홀수일 경우
        if (sLength % 2 != 0)
        {
            middleIndex = sLength / 2;
            cutLength = middleIndex;
            sb.Remove(0, cutLength);
            sb.Remove(1, cutLength);
            answer = sb.ToString();
        }
        else // 짝수일 경우
        {
            middleIndex = sLength / 2 - 1;
            cutLength = middleIndex;
            sb.Remove(0, cutLength);
            sb.Remove(2, cutLength);
            answer = sb.ToString();
        }
        return answer;
    }
}