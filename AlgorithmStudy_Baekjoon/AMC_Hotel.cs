using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy_Baekjoon
{
 /*   class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                string[] q = Console.ReadLine().Split();
                stringBuilder.AppendLine(((q[i + 1][2] % q[i + 1][0]) * 100 + (q[i + 1][2] / q[i + 1][0]) + 1).ToString());
            }
            Console.WriteLine(stringBuilder);


        }
    }*/

    /*
    // 1차 시도- 제출 방식 틀림 - 컴파일 에러.. 역시 프로그래머스가 친절한데 ㅜㅜ
    // 백준은 시작이 너무 어렵다.

    public int[] Solution(int[][] q)
    {
        int[] result = new int[q.Length-1];
        // q[1][0] = 층 수, q[1][1] = 방 수, q[1][2] = 손님 수, (문제에서 몫은 98을 넘지 않고, 손님 수는 문제의 범위를 벗어나지 않는다도 함.)
        // 문제를 읽고 산수 값의 몫과 나머지를 어떻게 구성할지 생각하여 배열에 적절히 집어넣는 문제
        //-> 나머지에 따라 층이 정해지고,호수는 (몫+1)의 값임. 
        for (int i = 0;i< q.Length - 1; i++)
        {
            result[i] = (q[i + 1][2] % q[i + 1][0]) * 100 + (q[i + 1][2] / q[i + 1][0]) + 1;
        }

        return result;
    }

    AMC_Hotel amcHotel = new AMC_Hotel();

    Console.WriteLine("Hello, World!");

    int[][] q = new int[3][]
    {
        new int[] {2},
        new int[] {6, 12, 10 },
        new int[] {30, 50, 72}
    };

    //Console.WriteLine(amcHotel.Solution(q));

    for (int i = 0; i < amcHotel.Solution(q).Length; i++)
    {
        Console.WriteLine(amcHotel.Solution(q)[i]);
    }

*/

}
