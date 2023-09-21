using System;
public class Solution {
        public long solution(long n)
        {
            long squareRoot = 0;
            
            squareRoot = (long)Math.Sqrt(n);
            
            return (Math.Pow(squareRoot, 2)) == n ? long.Parse(Math.Pow(squareRoot + 1, 2).ToString()) : -1;
 }
}
