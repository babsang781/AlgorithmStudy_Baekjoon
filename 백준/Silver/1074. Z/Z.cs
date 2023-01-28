using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        StringBuilder stringBuilder = new StringBuilder();

        string[] quiz = Console.ReadLine().Split();
        int N = int.Parse(quiz[0]);
        int r = int.Parse(quiz[1]);
        int c = int.Parse(quiz[2]);
        long result = 0;
        int count = 0;

        // 수를 이진수로 바꾸면 재귀를 하지 않아도 재귀적인 연산이 가능하다. 
        
        // r 을 2진수로 변경하고 자릿수에 따라 1인 경우 자릿수 * 2 + 1 을 모두 더한다. 2n+1승 + 나머지 값 + 나머지 값을 진행. 
        // c 는 2진수로 변경하고 자릿수에 따라 1인 경우 자릿수 * 2 을 모두 더한다. 2n승 + 나머지 값 + 나머지 값을 진행. 
        
        // 예를들어 (r, c)에서  i) r = 5, 101 -> 2^(2*0 + 1) + 2^(2*2 + 1) /  c = 6, 110 ->   2^(2*1) + 2^(2*2) 
        // ** N 값에 영향을 받지 않는다. ** Char Array 변환 및 Reverse 가 필요하다.  
 
        string rBin = Convert.ToString(r, 2);
        char[] rCharArray = rBin.ToCharArray();
        Array.Reverse(rCharArray);

        string cBin = Convert.ToString(c, 2);
        char[] cCharArray = cBin.ToCharArray();
        Array.Reverse(cCharArray);

        for (int i = 0; i < rCharArray.Length; i++)
        {
            if (rCharArray[i] == '1')
            {
                result += (long)Math.Pow(2, 2 * count + 1);
            }
            count++;
        }
        count = 0;

        for (int i = 0; i < cCharArray.Length; i++)
        {
            if (cCharArray[i] == '1')
            {
                result += (long)Math.Pow(2, 2 * count);
            }
            count++;
        }


        Console.WriteLine(result);
    }
}
