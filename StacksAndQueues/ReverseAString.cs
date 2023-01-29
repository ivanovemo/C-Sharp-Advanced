using System;
using System.Collections.Generic;

string input = Console.ReadLine();

Stack<char> stack = new();

foreach (char symbol in input)
{
    stack.Push(symbol);
}

while(stack.Count > 0)
{
    Console.Write(stack.Pop());
}