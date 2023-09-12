// https://github.com/LinkedInLearning/c-sharp-dot-net-essential-training-2453257/
// Hello world, adding numbers and char, reference and values types
Console.WriteLine("Hello, World!");

// int a = 1;
// char c = 'A';
// float f = 123.45f;
// decimal d = 400.85m;
// int b = default;
// bool tf = default;
// Console.WriteLine($"{a}, {c}, {f}, {d}, {b}, {tf}");

// Console.WriteLine($"{c + a}");
// Console.WriteLine($"{(char)(c + a)}");
// Console.WriteLine($"{a + f}");
// Console.WriteLine($"{c + f}");

// Creating struct instance
s s1;
// Initializing struct
s1.a = 1;
s1.b = true;

Console.WriteLine("Structs are passed by copy, since they are value types:");
Console.WriteLine($"{s1.a}, {s1.b}");
printS(s1);
Console.WriteLine($"{s1.a}, {s1.b}");

// Creating/initializing class instance
SClass test = new SClass{a=5,b=false};

Console.WriteLine("Objects are passed by reference, since they are reference types:");
Console.WriteLine($"{test.a}, {test.b}");
methodSClass(test);
Console.WriteLine($"{test.a}, {test.b}");

// Method that receives struct values, replace them and print them (receives values)
void printS(s structS){
structS.a = 2;
structS.b = false;
Console.WriteLine($"{structS.a}, {structS.b}");
}

// Creating method that receives initiated class instance and changes it (receives object)
void methodSClass(SClass inst){
    inst.a = 10;
    inst.b = true;
    Console.WriteLine($"{inst.a}, {inst.b}");
}

// Type declarations
class SClass{
    public int a;
    public bool b;
}

struct s {
    public int a;
    public bool b;
}















