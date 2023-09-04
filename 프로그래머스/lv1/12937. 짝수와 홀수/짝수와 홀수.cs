public class Solution {
    public string solution(int num) {
        string a = "";
        
        if (num % 2 == 0){
            a = "Even";
        }else{
            a = "Odd";
        }
        
        return a;
    }
}