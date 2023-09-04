public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        double total = 0;
        
        for (int i = 0; i < arr.Length; i++) {
            total += arr[i];
        }
        
        answer = total / arr.Length;
        return answer;
    }
}