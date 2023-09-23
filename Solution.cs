namespace Lv1_10
{
    class Solution
    {
        static void Main(string[] args)
        {
            long n = 1187382;
            long answer = 0;
            Solution1 s1 = new Solution1();
            answer = s1.solution(n);
            Console.WriteLine(answer);
        }
    }
}