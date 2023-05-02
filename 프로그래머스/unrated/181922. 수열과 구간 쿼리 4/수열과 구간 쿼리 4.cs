using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = (int[])arr.Clone();
        
        for( int i = 0; i< queries.GetLength(0); i++)
        {
            int s = queries[i,0];
            int e = queries[i,1];
            int k = queries[i,2];
            
            for ( int j = s ; j <= e ;j++)
            {
                if(j % k == 0)
                {
                    answer[j]++;
                }
            }  
        }
        
        return answer;
    }
}