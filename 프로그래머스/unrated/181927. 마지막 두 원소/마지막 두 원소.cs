using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int cnt = num_list.Length +1;
        int[] answer = new int[cnt] ;
        
        for( int i = 0 ; i < cnt-1; i++){
            answer[i] = num_list[i];
        }
        
        answer[cnt-1] = (num_list[cnt-2] > num_list[cnt-3])? num_list[cnt-2] - num_list[cnt-3]: num_list[cnt-2] *2;
        
        
        return answer;
    }
}