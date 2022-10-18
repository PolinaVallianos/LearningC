// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
float a = 10000.1f;
float b = 10000.01f;
double c = 0.125467;
b = (float)c;
Console.WriteLine(c);
byte b1 = 51;
int c1 = 257;
c1 = b1++;

Console.WriteLine(b1);
Console.WriteLine(c1);

int c2 = 4;
int c3 = 10;

Console.WriteLine(c3 / c2);
Console.WriteLine(c3 % c2);

Console.Write("Enter your number:  ");

string input = Console.ReadLine();
c3 = int.Parse(input);
Console.Write($"You enter: {c3} ");
//Console.WriteLine(c3);

