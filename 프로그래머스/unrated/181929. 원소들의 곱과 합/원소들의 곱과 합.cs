using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int pow =0;
        int multiple = 1;
        
        foreach( var num in num_list){
            multiple *= num;
            pow +=num;
        }
        answer = (multiple > Math.Pow(pow,2))? 0:1;
        
        return answer;
    }
}