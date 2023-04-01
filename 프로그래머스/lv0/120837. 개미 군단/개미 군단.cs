using System;

public class Solution {
    public int solution(int hp) {
        int answer = hp/5; 
        
        switch(hp%5){
            case 0: return answer;
            case 1: return answer+1;
            case 2: return answer+2;
            case 3: return answer+1;
            case 4: return answer+2;
        }
        return answer;
            
    }
}