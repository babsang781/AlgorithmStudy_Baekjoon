using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        
        for( int i =0; i< queries.GetLength(0); i++){
            int s = queries[i,0];
            int e = queries[i,1];
            int k = queries[i,2];
            int min = -1;
            for ( int j = s ; j <= e ;j++){
                if(k < arr[j]){
                    if(min == -1){
                        min = arr[j];
                    }                    
                    else if(min != -1 && min > arr[j]){
                        min = arr[j];
                    }
                }  
            }
            answer[i] = min;
        }
        
        
        return answer;
    }
}