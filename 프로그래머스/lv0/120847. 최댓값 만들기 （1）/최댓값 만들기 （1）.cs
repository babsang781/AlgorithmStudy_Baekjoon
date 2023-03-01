using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        int max = 0;
        int max2 = 0;
        
        for ( int i = 0 ; i < numbers.Length ; i++){
            if( numbers[i] >= max2){
                if( numbers[i] >= max){
                    max2 = max;
                    max = numbers[i];    
                }else{
                    max2 = numbers[i];
                }
            }
            
        }
        
        return max * max2;
    }
}

// 런타임 에러 2개  
// int max1 = numbers.Max();
// int max2 = numbers.Where(x => x != max1).Max();
// return max1 * max2;

// 인덱스 저장해서 풀기, 첫 인덱스 처리 방법이 어렵네
// int[] arr = new int [2]{ 0, 0};
// bool check = false;
// for ( int i = 0 ; i < numbers.Length ; i++ ){
// if( check && numbers[i] < numbers[arr[1]]) continue;
// if( numbers[i] >= numbers[arr[0]])
// {
// arr[1] = arr[0]; 
// arr[0] = i; 
// }
// else {
// check = true;
// arr[1] = i;
// }
// }
// return check ? numbers[arr[1]] * numbers[arr[0]] : 0;