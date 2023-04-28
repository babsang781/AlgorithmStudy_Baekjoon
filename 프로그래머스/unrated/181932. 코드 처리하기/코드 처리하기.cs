using System;

public class Solution {
    public string solution(string code) {
        string ret = "";
        int mode = 0;
        
        for(int i = 0 ; i < code.Length; i++)
        {
            if(code[i] == char.Parse("1"))
            {
                mode = (mode ==1)? 0:1;
                continue;
            }
            switch(mode){
                case 0:
                    if(i%2 == 0) ret +=code[i];
                    break;
                case 1:
                    if(i%2 == 1) ret +=code[i];
                    break;
            }
        }
        return ret.Length == 0? "EMPTY": ret;
    }
}