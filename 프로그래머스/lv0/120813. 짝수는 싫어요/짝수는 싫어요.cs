using System;

public class Solution {
    public int[] solution(int n)
    {
        int[] answer = new int[] { };

        int num = 0;
        if(n % 2 == 0) num = n/2; 
        if(n % 2 == 1) num = n/2 + 1;

        answer = new int[num];

        for(int i = 0; i < num; i++)
        {
            answer[i] = i*2 + 1;
        }

        return answer;
    }
}