//WorkWithIntegers();
OrderPrecedence();
testLimits();
WorkWithDoubles();

void WorkWithIntengers()
{
int a = 18;
int b = 6;
int c = a / b * 15;
Console.WriteLine(c);

//subraction 
c= a - b;
Console.WriteLine(c);

//multiplcation 
c = a* b;
Console.WriteLine(c);

//division 
c= a/b;
Console.WriteLine(c);
}

void OrderPrecedence()
{
int a = 5;
int b =4;
int c = 2;
int d = a + b;
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
void testLimits()
{
int a = 7;
int b = 4;
int c = 3;
int d = (a+b) / c;
int e = (a+b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of intergers is {min} to {max}");
int what = max + 3;
Console.WriteLine($"an example of overflow: {what}");
}
void WorkWithDoubles()
{
double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);

double e = 19;
double f = 23; 
double g = 8;
double h = (e+f) / g;
Console.WriteLine(h);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"the range of double is {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);
}

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"the range of the decimal type is {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a/b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c/d);

double PIE = System.Math.PI;
double Radius = 2.50;
double Area = PIE*System.Math.Pow(Radius, 2);
Console.WriteLine($"the area of the circle is {Area}");