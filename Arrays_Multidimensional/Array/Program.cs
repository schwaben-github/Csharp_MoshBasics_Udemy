int[] numbers = [3, 7, 9, 2, 14, 6];

// Length
Console.WriteLine("Length: " + numbers.Length);

// IndexOf()
var index = Array.IndexOf(numbers, 9);
Console.WriteLine("Index of 9 is: " + index);

// Clear()
Array.Clear(numbers, 0, 2);

Console.WriteLine("Effect of Clear()");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

// Copy()
int[] another = new int[3];
Array.Copy(numbers, another, 3);

Console.WriteLine("Effect of Copy()");
foreach (var n in another)
{
    Console.WriteLine(n);
}

// Sort()
Array.Sort(numbers);

Console.WriteLine("Effect of Sort()");
foreach (var n in numbers)
{
    Console.WriteLine(n);
}

// Reverse()
Array.Reverse(numbers);

Console.WriteLine("Effect of Reverse()");
foreach (var n in numbers)
{
    Console.WriteLine(n);
}

// Array.Method() - Static method of the Array class
// e.g. Array.Clear(), Array.Copy(), Array.IndexOf(), Array.Sort(), Array.Reverse()
// Otherwise, use instance methods of the array object
// e.g. numbers.Length