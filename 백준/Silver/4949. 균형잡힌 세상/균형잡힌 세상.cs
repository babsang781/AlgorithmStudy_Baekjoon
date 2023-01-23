using System;
using System.Linq;
using System.Text;
using System.Collections;

public class Program
{
    public static void Main()
    {
        StringBuilder stringBuilder = new StringBuilder();
        Stack stack = new Stack();

        while (true)
        {
            string line = Console.ReadLine();
            char[] lines = line.ToCharArray();
            if (line == ".")
            {
                break;
            }

            for (int i = 0; i < lines.Count(); i++)
            {
                // stack push 조건문
                if (lines[i] == '(')
                {
                    stack.Push(lines[i]);
                }
                else if (lines[i] == '[')
                {
                    stack.Push(lines[i]);
                }
                // stack pop 조건 및 "No" 조건 정리하기
                else if (lines[i] == ')')
                {
                    if ( !stack.Contains('('))
                    {
                        stringBuilder.AppendLine("no");
                        break;
                    }else if((char)stack.Peek() != '(')
                    {
                        stringBuilder.AppendLine("no");
                        break;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else if (lines[i] == ']')
                {
                    if (!stack.Contains('['))
                    {
                        stringBuilder.AppendLine("no");
                        break;
                    }
                    else if ((char)stack.Peek() != '[')
                    {
                        stringBuilder.AppendLine("no");
                        break;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }

                if(i == (lines.Count() - 1) && stack.Count == 0) {
					stringBuilder.AppendLine("yes");
				}else if(i == (lines.Count() - 1) && stack.Count != 0){
					stringBuilder.AppendLine("no");
				}
            }
        	stack.Clear();
		}
		
        Console.WriteLine(stringBuilder);
    }
}
