using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string myString) {
        List<int> answer = new List<int>();
        int temp = 0; 
        
        for( int i = 0; i < myString.Length; i++ ){
            
            if(myString[i] == 'x'){
                answer.Add(temp);
                temp = 0;
            }else{
                temp++;
            }
            if( i == myString.Length-1){
                    answer.Add(temp);
                }
        }
        
        return answer.ToArray();
    }
}