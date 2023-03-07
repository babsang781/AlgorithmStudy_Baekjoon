using System;

public class Solution {
    public int solution(int price) {
        int answer = 0;

        if ( price >= 500000 ) return price*8/10;
        else if ( price >= 300000 ) return price*9/10;
        else if ( price >= 100000 ) return price*95/100;
        else{
            return price;
        }        
    }
}