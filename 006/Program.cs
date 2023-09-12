// Parsing numbers

string[] NumStrs = {"  1 ", " 1.45  ", "-100", "5e+04 "};

int testint;
float testfloat;
bool result;

foreach(string str in NumStrs){
    try{
        testfloat = float.Parse(str);
        Console.WriteLine($"Parsed {str} to float is {testfloat}");
        testint = int.Parse(str);
        Console.WriteLine($"Parsed {str} to int is {testint}");
    }
    catch(FormatException e){
        Console.WriteLine($"Could not parse '{str}' : {e.Message}");
    }
}