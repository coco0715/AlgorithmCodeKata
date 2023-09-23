 public class Solution
 {
     public long solution(long n)
     {
         long answer = 0;
         string nStr = "";

         char[] nChar = n.ToString().ToCharArray();

         Array.Sort(nChar);
         Array.Reverse(nChar);

         foreach (char c in nChar)
         {
             nStr += c;
         }
         long.TryParse(nStr, out answer);
         //answer = long.Parse(nStr);
         //answer = Convert.ToInt32(nStr);
         return answer;
     }
 }
