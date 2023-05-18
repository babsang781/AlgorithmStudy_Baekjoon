using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int k) {
        List<int> list = new List<int>();
        
        for(int i = 1 ; i <= n ; i++){
            if(i%k ==0) list.Add(i);
            
        }
            
        return list.ToArray();
    }
}