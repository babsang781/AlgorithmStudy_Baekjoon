using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string myString) {
        
        // List<string> answer = new List<string>();
//         string temp = ""; 
//        
//         for( int i = 0; i < myString.Length; i++ ){
//             if(myString[i] == 'x'){
//                 answer.Add(temp);
//                 temp = "";
//             }else{
//                 temp += myString[i];
//             }
//         }
//      
//         if( myString[myString.Length-1] != 'x'){
//             answer.Add(temp);
//         }
//         answer.Sort();
//         return answer.ToArray();
        
        string[] words = myString.Split('x');
        
        List<string> answer = new List<string>(words);
        
        answer.Sort();

        return answer.Where(x => !string.IsNullOrEmpty(x)).ToArray();;
    }
}