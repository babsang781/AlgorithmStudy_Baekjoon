using System;

public class Solution {
    public string solution(string my_string, string letter) {
        if(!my_string.Contains(letter)) return my_string;

        string answer = "";
        for(int i= 0; i<my_string.Length; i++){
            if((my_string[i] + "") != letter){
                answer+=my_string[i];
            }
        }
        
        return answer;
    }
}