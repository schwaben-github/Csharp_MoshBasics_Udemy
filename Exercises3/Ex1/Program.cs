using System;
using System.Collections.Generic;

var names = new List<string>();
while (true)
{
    Console.Write("Enter a name (or press Enter to finish): ");
    var name = Console.ReadLine();
    if (string.IsNullOrEmpty(name))
        break;
    names.Add(name);
}

var numLikes = names.Count;
if (numLikes == 0)
{
    Console.WriteLine("");
}
else if (numLikes == 1)
{
    Console.WriteLine($"{names[0]} likes your post.");
}
else if (numLikes == 2)
{
    Console.WriteLine($"{names[0]} and {names[1]} like your post.");
}
else
{
    Console.WriteLine($"{names[0]}, {names[1]} and {numLikes - 2} others like your post.");
}