using System;
using System.Collections.Generic;

SortedSet<int> uniqueNumbers = new();

Console.WriteLine("Enter a number or type 'quit' to exit:");

while (true)
{
    string input = Console.ReadLine();

    if (input.ToLower() == "quit")
        break;

    if (int.TryParse(input, out int number))
    {
        uniqueNumbers.Add(number);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number or type 'quit' to exit.");
    }
}

Console.WriteLine("\nUnique numbers entered:");
foreach (int num in uniqueNumbers)
{
    Console.WriteLine(num);
}