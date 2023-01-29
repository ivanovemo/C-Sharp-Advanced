using System;
using System.Collections.Generic;
using System.Linq;

string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

Stack<string> stack = new();

for (int i = input.Length - 1; i >= 0; i--)
{
    stack.Push(input[i]);
}

while (stack.Count > 1)
{
    int firstElement = int.Parse(stack.Pop());
    string action = stack.Pop();
    int secondElement = int.Parse(stack.Pop());

    switch (action)
    {
        case "+":
            stack.Push((firstElement + secondElement).ToString());
            break;
            case "-":
            stack.Push((firstElement - secondElement).ToString());
            break;
    }
}

Console.WriteLine(stack.Pop());