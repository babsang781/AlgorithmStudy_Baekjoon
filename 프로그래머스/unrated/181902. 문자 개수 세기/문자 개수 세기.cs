using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[52];
        
        int idx1 = 65;
        int idx2 = 71;
        
        var arr = my_string.ToCharArray();
        foreach( var num in arr){
            if(num <=90) answer[num-idx1]++;
            if(num > 90) answer[num-idx2]++;
        }
        return answer;
    }
}