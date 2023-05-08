using System;

public class Solution {
    public string solution(string my_string, int m, int c) {
        string answer = "";
        
        for( int i = 0 ; i < (int)(my_string.Length/m); i++){
            answer+= my_string[c-1+(m*i)];
        }
        
        return answer;
    }
}