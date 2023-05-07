using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        int result = 0;
        List<string> list = new List<string>();
        for(int i = 0 ; i < my_string.Length ; i++){
            list.Add(my_string.Substring(i));
        }
        
        foreach( var str in list){
            if(str == is_suffix) result =1;
        }
        
        return result;
    }
}