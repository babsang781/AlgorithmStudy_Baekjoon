using System;

public class Solution {
    public string solution(string[] my_strings, int[,] parts) {
        string answer = "";
        
        for( int i = 0 ; i < my_strings.Length ; i++){

            int s = parts[i,0];
            int e = parts[i,1];
            string temp = my_strings[i].Substring(s, e-s+1);
            answer += temp;
        }
        
        return answer;
    }
}