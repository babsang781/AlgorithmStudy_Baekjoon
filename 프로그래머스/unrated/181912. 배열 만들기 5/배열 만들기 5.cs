using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {

        List<int> list = new List<int>();
        
        foreach( var num in intStrs){
            string tempStr = num +"";
            
            int tempInt = Int32.Parse(tempStr.Substring(s,l));
            if(tempInt > k) list.Add(tempInt);
            
        }
        
        
        return list.ToArray();
    }
}