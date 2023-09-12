// String interpolation

int a = 100;
float b = 250.0f;
string c = "CSharp";

// String output using placeholders (old way)
Console.WriteLine("The values are: {0}, {1} and {2}", a, b, c);

// Using string interpolation
Console.WriteLine($"The values are: {a}, {b} and {c}");
Console.WriteLine($"{c} in upper-case is {c.ToUpper()}");
Console.WriteLine($"Today is {DateTime.Now}");