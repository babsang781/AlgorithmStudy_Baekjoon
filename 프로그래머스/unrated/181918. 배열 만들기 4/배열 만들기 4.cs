using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> stk = new List<int>();
        int temp = 0;
        int i = 0;
        while(i < arr.Length){
            
            if(stk.Count == 0){
                stk.Add(arr[i]);
                i++;
            }else{
                temp = stk.Count;
                if(stk[temp-1] < arr[i]){
                    stk.Add(arr[i]);
                    i++;
                }else{
                    stk.RemoveAt(temp-1);
                }
            }
        }
        return stk.ToArray();
    }
}