using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";

        myString = myString.ToLower();
        
        for ( int i = 0 ; i < myString.Length ; i++){
            
            if(myString[i] == 'a'){
                answer += 'A';
            }else{
                answer += myString[i];
            }
        }
        
        return answer;
    }
}