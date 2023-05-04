using System;

public class Solution {
    public bool solution(bool x1, bool x2, bool x3, bool x4) {
        bool answer = false;
        bool sum1 = false;
        bool sum2 = false;
        if(x1 == true || x2 == true){
            sum1 = true;
        }
        if(x3 == true || x4 == true){
            sum2 = true;
        }
        
        if(sum1 == true && sum2 == true) answer = true;
        return answer;
    }
}