using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        //int[] answer = new int[] {};
        
        // int[] answer = numbers.Select( x => x * 2) ;
        return numbers.Select(x => x * 2).ToArray();
        
        //return numbers.Where(x => x*2).ToArray();
    }
}