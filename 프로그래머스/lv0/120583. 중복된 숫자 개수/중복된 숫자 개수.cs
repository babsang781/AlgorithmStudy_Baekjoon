using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        
        // for문 
        for( int i = 0 ; i < array.Length; i++){
            answer += array[i] == n ? 1 : 0;
        }
        // Linq
        return answer;
    }
}