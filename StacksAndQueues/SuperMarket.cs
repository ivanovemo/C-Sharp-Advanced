using System;
using System.Collections.Generic;
using System.Data;

Queue<string> queue = new();

string command = string.Empty;
while((command = Console.ReadLine()) != "End")
{
    string name = command;
    if (name == "Paid")
    {
        Console.WriteLine(string.Join(Environment.NewLine, queue));
        queue.Clear();
        continue;
    }
    queue.Enqueue(name);
}

Console.WriteLine($"{queue.Count} people remaining.");