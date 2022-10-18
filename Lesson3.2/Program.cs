// See https://aka.ms/new-console-template for more information

byte byteNumber = 13;
short shortNumber = 32124;
int intNumber = 1235456;
long longNumber = 632156155;

byteNumber = (byte) shortNumber;


longNumber = longNumber + intNumber;
longNumber += intNumber;


string string1, string2;
string1 = "My name";
string2 = "Polina";

string1 += string2;

Console.WriteLine(string1);

Console.WriteLine(byteNumber);

Console.WriteLine(byteNumber > shortNumber);
Console.WriteLine(byteNumber+2 >= shortNumber);
Console.WriteLine(byteNumber <= shortNumber);
Console.WriteLine(byteNumber == shortNumber);
Console.WriteLine(byteNumber != shortNumber);