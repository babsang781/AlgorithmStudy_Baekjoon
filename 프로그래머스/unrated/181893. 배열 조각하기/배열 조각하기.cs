using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] query) {
        // 이 문제는 설명대로 분기 조건 따박따박하면 될 듯
        // 단, list 로 만들어서
        List<int> list = arr.ToList();
        //List<int> temp = new List<int>();

        for(int i = 0 ; i < query.Length; i++){
            List<int> temp = new List<int>();

            if(i%2 == 0 ){
                int idxEnd = query[i];
                for(int j = 0; j <= idxEnd; j++){
                    temp.Add(list[j]);
                }
            }else{
                int idxStart = query[i];
                for(int j = idxStart; j < list.Count; j++){
                    temp.Add(list[j]);
                }
            }
            list = temp;
        }        
            // int idxEnd = query[0];
            // for(int j = 0; j <= idxEnd; j++){
            //     temp.Add(list[j]);
            // }
            // list = temp;
        
        return list.ToArray();
    }
}