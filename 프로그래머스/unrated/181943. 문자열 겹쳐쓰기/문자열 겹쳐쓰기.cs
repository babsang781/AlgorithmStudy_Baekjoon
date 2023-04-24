using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        string answer = "";
        
        
        answer += my_string.Substring(0, s);
        answer += overwrite_string;
        
        int ss = s + overwrite_string.Length;
        
        
        if(my_string.Length > ss){
            answer += my_string.Substring( ss);
        }
            
        return answer;
    }
}