// See https://aka.ms/new-console-template for more information
using AlgorithmStudy_Baekjoon;


using System;
using System.Text;

namespace backjoon
{
    class Program
    {

        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                string[] q = Console.ReadLine().Split();
                int h = int.Parse(q[0]);
                int w = int.Parse(q[1]);
                int n = int.Parse(q[2]);
                stringBuilder.AppendLine(
                    ((n % h == 0 ? h : n % h) * 100 + 
                    (n%h == 0 ? n/h : n/h+1)
                    ).ToString());
            }
            Console.WriteLine(stringBuilder);


        }
        
    }
}



