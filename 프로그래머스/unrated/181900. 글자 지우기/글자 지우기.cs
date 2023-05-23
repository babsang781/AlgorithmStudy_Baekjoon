using System;


public class Solution {
    public string solution(string my_string, int[] indices) {
        string answer = "";
        // indices 정렬, 총 길이 순회하면서 indices 배열 안에 숫자가 아니면 새string 에 추가
        
        Array.Sort(indices);
        for(int i = 0; i< my_string.Length; i++){

            bool check = true;
            for(int j= 0 ; j <indices.Length; j++){
                if(i == indices[j])check = false;                    
            }

            if(check == true) answer += my_string[i]; 
        }
        
        
        return answer;
    }
}