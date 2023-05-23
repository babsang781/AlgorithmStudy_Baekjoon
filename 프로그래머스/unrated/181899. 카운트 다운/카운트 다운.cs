using System;

public class Solution {
    public int[] solution(int start, int end) {
        int len = start - end +1;
        int[] answer = new int[len];
        
        for(int i = 0; i < len ; i++){
            answer[i] = start-i;
        }
        return answer;
    }
}