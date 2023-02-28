using System;

public class Solution {
    public int solution(int angle) {
        
        if( angle < 90 ) return 1;
        else if( angle == 90 ) return  2;
        else if( angle < 180 ) return 3;
        else
        {
            return 4;
        }
        
        
        
    }
}

//int result = 0;
//         if( angle < 90 ) result = 1;
//         else if( angle == 90 ) result = 2;
//         else if( angle < 180 ) result = 3;
//         else
//         {
//             result = 4;
//         }
        
//         return result;