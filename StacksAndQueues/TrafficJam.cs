using System;
using System.Collections.Generic;

Queue<string> queue = new();
int passCars = int.Parse(Console.ReadLine());

int totalPassed = 0;
string command = string.Empty;
while ((command = Console.ReadLine()) != "end")
{
    string carOrGreen = command;

    if (carOrGreen == "green")
    {
        for (int i = 0; i < passCars; i++)
        {
            while (queue.Count > 0)
            {
                totalPassed++;
                Console.WriteLine($"{queue.Dequeue()} passed!");
            }
        }
        continue;
    }

    queue.Enqueue(carOrGreen);

}

Console.WriteLine($"{totalPassed} cars passed the crossroads.");