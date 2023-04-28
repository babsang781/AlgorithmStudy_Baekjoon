using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        string odd ="";
        string even = "";
        
        foreach(var num in num_list){
            if(num % 2 ==0) even +=""+num;
            if(num % 2 ==1) odd +=""+num;
        }
        
        
        return Int32.Parse(even) + Int32.Parse(odd);
    }
}