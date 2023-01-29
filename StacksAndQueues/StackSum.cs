using System;
using System.Collections.Generic;
using System.Linq;

Stack<int> stack = new(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
string command = string.Empty;

while((command = Console.ReadLine().ToLower()) != "end")
{
    string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    switch(tokens[0])
    {
        case "add":
            stack.Push(int.Parse(tokens[1]));
            stack.Push(int.Parse(tokens[2]));
            break;
        case "remove":
            if (stack.Count >= int.Parse(tokens[1]))
            {
                for (int i = 0; i < int.Parse(tokens[1]); i++)
                {
                    stack.Pop();
                }
            }
            break;
    }
}

int sumStack = 0;
while (stack.Count > 0)
{
    sumStack += stack.Pop();
}

Console.WriteLine("Sum: " + sumStack);