// Value types are copied when assigned to another variable
int a = 10;
int b = a;

Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); // a: 10, b: 10
b++;
Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); // a: 10, b: 11


// Reference types are not copied when assigned to another variable
var array1 = new int[3] { 1, 2, 3 };
var array2 = array1;

Console.WriteLine(string.Format("array1: {0}, array2: {1}", array1[0], array2[0]));
array2[0] = 100;
Console.WriteLine(string.Format("array1: {0}, array2: {1}", array1[0], array2[0]));
