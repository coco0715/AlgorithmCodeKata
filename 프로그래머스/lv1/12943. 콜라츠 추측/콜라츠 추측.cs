public class Solution {
   public int solution(int n)
{
    long answer = n;
    int count = 0;

    for (int i = 0; i < 500; i++)
    {
        if (answer == 1)
        {
            return count;
        }
        else
        {
            count++;
            if (answer % 2 == 0)
            {
                answer = answer / 2;
            }
            else
            {
                answer = (answer * 3) + 1;
            }
        }
    }
    
    if (answer != 1)
    {
        count = -1;
    }
    return count;
}
}