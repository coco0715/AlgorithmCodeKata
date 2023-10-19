using System.Text;

public class Solution {
     public string solution(int n)
     {
        string answer = "";
        string water = "수";
        string melon = "박";

        StringBuilder sb = new StringBuilder(answer);

        for(int i = 1; i <= n; i++)
        {
            if (i % 2 != 0) {
                sb.Append(water);
            }
            else
            {
                sb.Append(melon);
            }
        }

        answer = sb.ToString();

        return answer;
    }
}