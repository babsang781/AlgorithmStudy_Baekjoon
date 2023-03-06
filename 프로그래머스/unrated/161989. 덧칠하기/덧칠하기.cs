using System;
using System.Linq;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        // 문제 입력, 배열 생성

        // 0 초기화 배열 생성
        // visited 배열 생성 
        int[] q = new int[n];
        int[] visited = new  int[n];
        for( int i = 0 ; i < q.Length ; i++){ 
            visited[i] = 0;
            q[i] = 0; 
        }
        
        // section 위치에 1 insert
        for( int i = 0; i < section.Length; i++){
            q[section[i]-1] = 1;
        } 

        
        // 1인 곳부터 m길이 만큼 1 입력, answer++ 
        for( int i = 0; i < q.Length ; i++)
        {
            if( q[i] == 1 && visited[i] != 1){
                answer++;
            
                for( int j = 0 ;j < m ; j++)
                {
                    if(i + j < n){
                        visited[i+j] = 1;
                    }

                }   
            } 
            
                
        }
        
        
        return answer;
    }
}