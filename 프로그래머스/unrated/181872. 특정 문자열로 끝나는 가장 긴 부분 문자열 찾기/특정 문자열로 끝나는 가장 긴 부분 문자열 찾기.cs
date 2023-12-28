using System;

public class Solution {
    public string solution(string myString, string pat) {
        string answer = "";
        int patLength = pat.Length;
        int myStringLength = myString.Length;
        
        for ( int i = myStringLength; i > 0; i-- ){
            
            if(i >= patLength){
                string sub = myString.Substring(0, i);
                string compareString = sub.Substring( sub.Length - patLength, patLength );

                if( compareString == pat){
                    return sub;
                }    
            }
        }
        
        return answer;
    }
}