// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//WorkWithIntegers();
OrderPrecedence();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);

    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}

void WorkwithDecimals()
{
// Explore integer precision and limits
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

// Work with the double type
double da = 5;
double db = 4;
double dc = 2;
double dd = (da + db) / dc;
Console.WriteLine(dd);

double da2 = 19;
double db2 = 23;
double dc2 = 8;
double dd2 = (da2 + db2) / dc2;
Console.WriteLine(dd2);

double maxDouble = double.MaxValue;
double minDouble = double.MinValue;
Console.WriteLine($"The range of double is {minDouble} to {maxDouble}");

double third = 1.0 / 3.0;
Console.WriteLine(third);
}

// Work with decimal type
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

//Challenege 
double radius = 2.50;
double area = radius * radius * Math.PI;
Console.WriteLine(area);
