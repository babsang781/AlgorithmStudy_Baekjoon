using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = my_string.Substring(0, s);
        
        string temp ="";
        temp= my_string.Substring(s, e-s+1);
        char[] arr = temp.ToCharArray();
        Array.Reverse(arr);
        answer += new string(arr);
         
        answer +=my_string.Substring(e+1);  
        return answer;
    }
}