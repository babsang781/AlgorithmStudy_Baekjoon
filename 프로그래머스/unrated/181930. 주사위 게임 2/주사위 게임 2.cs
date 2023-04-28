using System;

public class Solution {
    public int solution(int a, int b, int c) {
        int answer = 0;
        if( a!=b && a!=c && b!=c) answer += a+b+c;
        
        if( (a == b && a!=c && b!=c)
            || (a == c && a!=b && b!=c)
            || (b == c && a!=c && b!=a))
        {
            answer += (int)((a+b+c) * (Math.Pow(a,2) + Math.Pow(b,2)+Math.Pow(c,2)));
        }
        
        if(a ==b && b==c){
            answer += (int)((a+b+c) * (Math.Pow(a,2) + Math.Pow(b,2)+Math.Pow(c,2))*(Math.Pow(a,3) + Math.Pow(b,3)+Math.Pow(c,3)));
            
        }
        
        
        
        return (int)answer;
    }
}