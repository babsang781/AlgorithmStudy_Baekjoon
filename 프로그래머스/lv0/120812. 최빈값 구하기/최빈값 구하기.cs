using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array) {
        
        Dictionary<int, int> temp = new Dictionary<int, int>();
        
        foreach(var num in array)
        {
            if(temp.ContainsKey(num)){
                temp[num] += 1;
            }else{
                temp.Add(num, 1);
            }
        }
        
        return check(temp);

    }
    
    public int check(Dictionary<int, int> dic)
    {
        int max = 0;
        int key = 0;
        bool chk = false;
        foreach(KeyValuePair<int, int> kvp in dic)
        {
            if(kvp.Value > max){
                max = kvp.Value;
                key = kvp.Key;
                chk = false;
            }else if( kvp.Value == max){
                chk = true;
            }
        }
        return chk? -1:key; 
    }
}