using System;
using System.Collections.Generic;

string input = Console.ReadLine();

Stack<int> stack = new();

for (int i = 0; i < input.Length; i++)
{
    int openingBracket = 0;
    if (input[i] == '(')
    {
        stack.Push(i);
    }
    if (input[i] == ')')
    {
        openingBracket = stack.Pop();
        for (int j = openingBracket; j <= i; j++)
        {
            Console.Write(input[j]);
        }
        Console.WriteLine();
    }
}