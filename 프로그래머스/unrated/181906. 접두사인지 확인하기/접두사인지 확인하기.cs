using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int answer = 0;
        string[] arr = new string[my_string.Length];
        
        for(int i = 0 ; i < my_string.Length; i++){
            arr[i] = my_string.Substring(0,i+1);
            if(is_prefix == arr[i]) answer = 1;
        }
        
        return answer;
    }
}