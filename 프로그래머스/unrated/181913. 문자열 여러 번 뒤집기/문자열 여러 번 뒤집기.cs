using System;

public class Solution {
    public string solution(string my_string, int[,] queries) {
        string answer = my_string;
        
        for(int i= 0 ;i < queries.GetLength(0); i++){
            int start = queries[i,0];
            int end = queries[i,1];
            
            string temp1 =""; 
            string temp2 =""; 
            string rev =""; 
            if(start != 0)  temp1 = answer.Substring(0, start);
            
            rev = answer.Substring(start, end-start+1);
            
            char[] charArray = rev.ToCharArray(); // 문자열을 char 배열로 변환
            Array.Reverse(charArray); // char 배열을 뒤집음
            rev = new string(charArray); 
            
            temp2 = answer.Substring(end+1);
            
            answer = temp1 + rev + temp2;
        }
        
        return answer;
    }
    
}