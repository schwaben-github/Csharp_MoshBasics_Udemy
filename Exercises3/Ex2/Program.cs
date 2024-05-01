using System;

Console.Write("Enter your name: ");
var name = Console.ReadLine();

char[] nameArray = name.ToCharArray();
Array.Reverse(nameArray);

var reversedName = new string(nameArray);
Console.WriteLine($"Reversed name: {reversedName}");