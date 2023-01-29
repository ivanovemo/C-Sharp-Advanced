using System;
using System.Collections.Generic;
using System.Linq;

int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Queue<int> evenNumbers = new();

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        evenNumbers.Enqueue(number);
    }
}

Console.WriteLine(string.Join(", ", evenNumbers));