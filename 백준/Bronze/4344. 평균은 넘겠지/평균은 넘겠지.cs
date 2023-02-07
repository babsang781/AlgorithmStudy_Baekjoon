using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        StringBuilder stringBuilder = new StringBuilder();

        int quizCnt = int.Parse(Console.ReadLine());
        for (int i = 0; i < quizCnt; i++)
        {
            string[] arr = Console.ReadLine().Split();

            int J = int.Parse(arr[0]);
            int sum = 0;
            double mean = 0;
            int count = 0;
            double ratio = 0;

            // 각 케이스 별로 처리할 준비
            // 순회해서 합, 나누기 J 를 통해 평균 구하기
            // 다시 순회해서 평균보다 큰 학생 수 구하고 비율 반올림 입력 
            //1
            for (int j = 1; j <= J; j++)
            {
                sum += int.Parse(arr[j]);
            }
            mean = sum / J;
            //2
            for (int j = 1; j <= J; j++)
            {
                if (int.Parse(arr[j]) > mean) { count++; }
            }

            ratio = (double)count / J;
            stringBuilder.AppendLine(string.Format("{0:0.000}%", ratio*100));
            // stringBuilder.AppendLine($"{ratio * 100:00.000}%");

        }


        Console.WriteLine(stringBuilder.ToString());
    }
}