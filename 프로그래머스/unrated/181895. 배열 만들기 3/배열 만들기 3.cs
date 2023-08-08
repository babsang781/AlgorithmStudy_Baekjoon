using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        
        List<int> list = new List<int>();
        
        int start1 = intervals[0,0];
        int end1 = intervals[0,1];
        int start2 = intervals[1,0];
        int end2 = intervals[1,1];
        
        list = AddIntervals(arr, start1, end1);
        list.AddRange(AddIntervals(arr, start2, end2));
        
        return list.ToArray();
    }
    
    public List<int> AddIntervals(int[] arr, int start, int end){
         List<int> temp = new List<int>();
        
        for(int i = 0 ; i < arr.Length; i++){
            if(i >= start && i <= end){
                temp.Add(arr[i]);        
            }
        }
        return temp;
    } 
        
        
}