using System;

public class Solution {
    public int solution(int a, int b, int c, int d) {
        int[] counts = new int[7]; // 각 숫자가 몇 번 나왔는지 카운트하는 배열
        counts[a]++;
        counts[b]++;
        counts[c]++;
        counts[d]++;

        int maxCount = 0;
        int minCount = 0;
        int maxValue = 0;

        // 1. 네 주사위에서 나온 숫자가 모두 같은 경우
        for (int i = 1; i <= 6; i++) {
            if (counts[i] == 4) {
                return i * 1111;
            }
        }

        // 2. 세 주사위에서 나온 숫자가 같고 나머지 하나는 다른 경우
        for (int i = 1; i <= 6; i++) {
            if (counts[i] == 3) {
                maxCount = i;
                break;
            }
        }
        if(maxCount > 0){
            for (int i = 1; i <= 6; i++) {
                if (counts[i] == 1) {
                    minCount = i;
                    break;
                }
            }
            
            return (int)Math.Pow(10 * maxCount + minCount, 2);
        }
    
        

        // 3. 두 개의 주사위 쌍이 같은 경우
        for (int i = 1; i <= 6; i++) {
            if (counts[i] == 2) {
                if(minCount != 0 && maxCount == 0 ) maxCount = i;
                if(minCount == 0) minCount = i;
            }
        }
        if(minCount > 0 && maxCount > 0 ) {
            return (minCount + maxCount) * Math.Abs(maxCount - minCount);
        }
        if(minCount > 0 && maxCount == 0){
            int mul = 1;
            for (int i = 1; i <= 6; i++) {
                if (counts[i] == 1) {
                    mul*= i;
                }
            }
            return mul;
        }

        // 4. 네 주사위가 모두 다른 경우
        int minVal = 7;
        for (int i = 1; i <= 6; i++) {
            if (counts[i] == 1 && i < minVal) {
                minVal = i;
            }
        }

        return minVal;
    }
}