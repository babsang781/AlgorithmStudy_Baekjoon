using System;

public class Solution {
    public int solution(string binomial) {

        int answer = 0;
        string[] arr = binomial.Split();
        
        if(
            Int32.TryParse(arr[0], out int i) && 
            Int32.TryParse(arr[2], out int j))
        {
            if(arr[1].Contains("+")){
                answer = i + j;
            }
            else if(arr[1].Contains("-")){
                answer = i - j;
            }
            else if(arr[1].Contains("*")){
                answer = i * j;
            }
            
        }
        return answer;
    }
}