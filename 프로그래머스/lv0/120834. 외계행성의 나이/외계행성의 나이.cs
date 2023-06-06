using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        int len = (age+"").Length;
        int[] arr = new int[len];
        int temp = age;
        
        for( int i = 1; i<=len; i++){
            arr[i-1] = (int)(temp % 10);
            temp = (int)(temp/10);
        }
        
        Array.Reverse(arr);

        foreach( var num in arr){
            if(num == 0)       {answer+= "a";
            }else if(num == 2) {answer+= "c";
            }else if(num == 3) {answer+= "d";
            }else if(num == 4) {answer+= "e";
            }else if(num == 1) {answer+= "b";
            }else if(num == 5) {answer+= "f";
            }else if(num == 6) {answer+= "g";
            }else if(num == 7) {answer+= "h";
            }else if(num == 8) {answer+= "i";
            }else if(num == 9) {answer+= "j";}
        }        
        return answer;
    }
}
    
       
