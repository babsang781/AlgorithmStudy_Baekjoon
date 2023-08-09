using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        // 1. for 문으로 list에 2 의 인덱스를 담음
        // i) 2가 없으면 -1 
        // ii) 2가 하나면 2 
        // iii) 2가 2개 이상이면 처음 2 idx 부터 끝 2 idx 까지 
        
        // 1
        List<int> list = new List<int>();
        for( int i = 0 ; i < arr.Length; i++){
            if(arr[i] == 2 ) list.Add(i);
        }
        
        // 
        List<int> result = new List<int>();
        
        if(list.Count == 0 ){
            result.Add(-1);
        }else if( list.Count == 1 ){
            result.Add(2);
        }else{
            int start = list[0];
            int end = list[list.Count-1];
            for( int i = start; i <= end; i++){
                result.Add(arr[i]);
            }
        }
        
        return result.ToArray();
    }
}