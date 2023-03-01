using System;
using System.Linq;

public class Solution {
    public double solution(int[] numbers) {
        if (numbers.Length == 0 || numbers.Length > 100) {
            throw new Exception("invalid param length");
        }
        if (numbers.Where(x=>x<0 || x>1000).Any() == true) {
            throw new Exception("invalid element");
        }
        return numbers.Average();
    }
}