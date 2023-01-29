using System;
using System.Collections.Generic;
using System.Linq;

Queue<string> queue = new(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
int explosion = int.Parse(Console.ReadLine());

int tosses = 1;
while (queue.Count > 1)
{
    string kid = queue.Dequeue();
    if (tosses < explosion)
    {
        tosses++;
        queue.Enqueue(kid);
    }
    else
    {
        tosses = 1;
        Console.WriteLine($"Removed {kid}");
    }
}

Console.WriteLine($"Last is {queue.Dequeue()}");