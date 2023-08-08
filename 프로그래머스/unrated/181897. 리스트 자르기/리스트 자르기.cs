using System;
using System.Linq;
using System.Collections.Generic;


public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        int[] answer = new int[] {};
        
        if(n == 1)
        {
            answer = GetArray(0, slicer[1], num_list);    
        }
        else if( n == 2)
        {
            answer = GetArray(slicer[0], num_list.Length-1, num_list);    
        }
        else if( n == 3)
        {
            answer = GetArray(slicer[0], slicer[1], num_list);    
        }
        else if( n == 4)
        {
            answer = GetArraySlice(slicer, num_list);
        }
        return answer;
    }
        
     public int[] GetArray(int idxStart, int idxEnd, int[] num_list)
     {
        // length 길이는 인덱스가 아니어서 +1 을 해줘야 하는데 빼먹음 *** 주의 하자 ***
        int length = idxEnd - idxStart+1;
        int[] array = new int[length];
         
        int j = 0;
        for(int i = 0; i< num_list.Length; i++){
            if(IsRange(i, idxStart, idxEnd))
            {
                array[j] = num_list[i];
                j++;
            }
        }
         return array;
     }
    
    public bool IsRange(int idx, int idxStart, int idxEnd){
        return (idx >= idxStart && idx <= idxEnd);
    }
    
    public int[] GetArraySlice(int[] slicer, int[] num_list)
    {
        List<int> list = new List<int>();
        int idxStart = slicer[0];
        int idxEnd = slicer[1];
        int term = slicer[2];
        
        int length = idxEnd - idxStart + 1;
         
        int j = 0;
        for(int i = idxStart; i<= idxEnd; i+=term)
        {
        
            
                list.Add(num_list[i]);
            
        }
        
        return list.ToArray();
    }
        
}

