using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();

        string input = Console.ReadLine();

        sb.Append(input + "??!");
        Console.Write(sb);
    }
}