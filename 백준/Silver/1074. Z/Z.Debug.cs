using System;
using System.Linq;
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

        // r 은 2 의 n 승 보다 값보다 하나 작은 값을 기준으로 2n+1승 + 나머지 값 + 나머지 값의 재귀적 계산을 한다.
        // 내 생각에는 r을 2로 나눈 값을 다시 2로 나누는 방법을 반복하여 2의 몇 승 더하기 몇 승 으로 나누고 하면 될 것 같은데 
        // 계산식을 세우려니 복잡하다. 
        
        // 두 번째 for 문에서 cCharArray를 안 넣고 rCharArray를 넣고 돌리고 있었다. 이걸 몇 시간 동안 찾아헤맴... ㅜㅜ 

        string rBin = Convert.ToString(r, 2);
        char[] rCharArray = rBin.ToCharArray();
        Array.Reverse(rCharArray);
        Console.WriteLine(rCharArray);

        string cBin = Convert.ToString(c, 2);
        char[] cCharArray = cBin.ToCharArray();
        Array.Reverse(cCharArray);
        Console.WriteLine(cCharArray);

        for (int i = 0; i < rCharArray.Length; i++)
        {
            if (rCharArray[i] == '1')
            {
                result += (long)Math.Pow(2, 2 * count + 1);
            }
            count++;
        }
        Console.WriteLine("result r: " + result);

        count = 0;

        for (int i = 0; i < cCharArray.Length; i++)
        {
            Console.WriteLine("");
            Console.WriteLine("count = "+ count + "    i = " + i+ "   rCharArray[i] = "+ rCharArray[i]);

            if (cCharArray[i] == '1')
            {
                Console.WriteLine("result : " + result+ "   (long)Math.Pow(2, 2 * count) = " + (long)Math.Pow(2, 2 * count));
                Console.WriteLine();

                result += (long)Math.Pow(2, 2 * count);
                Console.WriteLine("after result : " + result);

            }
            count++;
        }


        Console.WriteLine("result r+c : " + result);
    }
}
