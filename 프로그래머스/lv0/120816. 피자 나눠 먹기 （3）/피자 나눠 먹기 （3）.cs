using System;

public class Solution {
    public int solution(int slice, int n) {
//         int answer = 1;
//         for(int i = 1; i <= n/2; i++){
//             if( answer * slice / n == 0){
//                 answer++;
//             } else{
//                 break; 
//             }
//         }
        
//         return answer;
        return n % slice > 0 ? n / slice + 1 : n / slice;

    }
}