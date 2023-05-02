using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        
        List<int> ans = new List<int>();
        int[] a = new int[8] { 1,2,3,4,6,7,8,9};
        for(int i = l; i <= r;i++){
            bool chk = false;
            string str = i+"";
            foreach(var num in a){
                if(str.Contains(num+"")) chk = true;
            }
            
            if(chk) continue;
            ans.Add(i);
        }
        if(ans.Count == 0) ans.Add(-1);
        
        int[] answer = ans.ToArray();
        return answer;
    }
}