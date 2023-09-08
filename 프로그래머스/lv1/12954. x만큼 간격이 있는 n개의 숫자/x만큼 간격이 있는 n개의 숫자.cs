using System.Collections.Generic;
public class Solution {
    public long[] solution(int x, int n) {
    List<long> answer = new List<long>();
    int count = 1;

    for (long i = 0; i < n; i++)
    {
    answer.Add((long)x * count);
    count++;
    }
    return answer.ToArray();
    }
}