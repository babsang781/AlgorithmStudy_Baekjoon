using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        
        // 방법1. for> if 
        // for > 삼항
        // Linq
        // return absolutes.Select((t, idx) => signs[idx]? t : -t).Sum();

         
        for( int i = 0 ; i < signs.Length; i++){
            //if(signs[i] == true){
            // if(signs[i]){
            //   answer += absolutes[i];  
            // }else{
            //  answer -= absolutes[i];
            // }
            answer += signs[i]? +absolutes[i]: -absolutes[i];
        }
        return answer;
    }
}