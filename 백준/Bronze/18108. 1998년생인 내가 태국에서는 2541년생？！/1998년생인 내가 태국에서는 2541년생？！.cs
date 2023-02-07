using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        StringBuilder stringBuilder = new StringBuilder();

        // string[] quiz = Console.ReadLine().Split();
        
		int yearBangkok = int.Parse(Console.ReadLine());

        stringBuilder.Append("" + (yearBangkok - 543));

        Console.WriteLine(stringBuilder.ToString());
    }
}