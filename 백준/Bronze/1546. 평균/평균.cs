using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        // 1. 문제 : 과목 개수 N , 각각의 점수를 int[]로 받기
        int N = int.Parse(Console.ReadLine());
        string[] arr = Console.ReadLine().Split();

        // 2. 최고점 뽑기
        double max = 0;
        for(int i = 0; i < N; i++)
        {
            // 필요 없는 조건을 기준으로 다음 반복으로 바로 이동
            if (int.Parse(arr[i]) < max)
            {
                continue;
            }
            max = int.Parse(arr[i]);
        }

        double mean = 0;
        // 3. 새로운 평균 구하기    
        for (int i = 0; i < N; i++)
        {
            mean += int.Parse(arr[i]) / max * 100;
        }
        mean /= N;

        // 4. 결과 출력하기
        
        Console.WriteLine(mean);
    }
}
