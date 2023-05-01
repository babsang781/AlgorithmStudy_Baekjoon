using System;

public class Solution {
    public string solution(int[] numLog) {
        string answer = "";
        int num = 0; 

        for( int i = 1 ; i < numLog.Length;i++){
            num = numLog[i] - numLog[i-1];

            switch(num){
                case 1:
                    answer = answer+"w";
                    break;
                case -1:
                    answer = answer+"s";
                    break;
                case 10:
                    answer = answer+"d";
                    break;
                case -10:
                    answer = answer+"a";
                    break;
            }    
        }
        
        return answer;
    }
}