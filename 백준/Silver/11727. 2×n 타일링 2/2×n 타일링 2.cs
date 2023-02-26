using System;

public class Program
{
    public static void Main()
    {
        string v = Console.ReadLine();
        int num = int.Parse(v);

        int[] dp = new int[1001];
        dp[1] = 1;
        dp[2] = 3;

        for (int i = 3; i <= num; i++) 
        {
            dp[i] = (dp[i - 1] + 2 * dp[i - 2]) % 10007;
        }
        Console.WriteLine(dp[num]);
    }
}