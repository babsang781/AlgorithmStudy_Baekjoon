using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[] {0, 0};
        
        foreach(var num in num_list){
            if(num % 2 == 0) answer[0] ++;
            if(num % 2 == 1) answer[1] ++;
        }
        return answer;
    }
}