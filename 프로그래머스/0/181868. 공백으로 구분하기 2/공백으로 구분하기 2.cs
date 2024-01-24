using System;

public class Solution {
    public string[] solution(string my_string) {
        
        // string[] answer = my_string.Trim().Replace("  "," ").Replace("  "," ").Split(" ");
        // return answer;
        
        return my_string.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    }
}