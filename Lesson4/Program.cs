
//a++ = отдает значение и после прибавляет 1
//
int a = 0;
int b = 1;

int c = a++ + ++b;

const int Today = 25;

///Today = 0;

Console.WriteLine($"c = {c}, a = {a}, b = {b}");

c = a++ + a;

Console.WriteLine($"c = {c}, a = {a}"); //a = 2, c = 3
Console.WriteLine($"a = {a++}, a = {++a}"); //a = 2, a = 4


// булевы операторы
bool isTrue = true;
bool isFalse = false;

Console.WriteLine("\noperator not");
Console.WriteLine($"!true = {!isTrue}");
Console.WriteLine($"!false = {!isFalse}");


Console.WriteLine("\noperator and");
Console.WriteLine($"true && true = {isTrue && isTrue}"); //если первый оператор true или false, то второй оператор не проверятеся.просто быстрее работает
Console.WriteLine($"true & false = {isTrue & isFalse}");
Console.WriteLine($"false & false = {isFalse & isFalse}");


Console.WriteLine("\noperator or");
Console.WriteLine($"true | true = {isTrue | isTrue}");
Console.WriteLine($"true | false = {isTrue | isFalse}");
Console.WriteLine($"false | false = {isFalse | isFalse}");


Console.WriteLine("\noperator xor");
Console.WriteLine($"true ^ true = {isTrue ^ isTrue}");
Console.WriteLine($"true ^ false = {isTrue ^ isFalse}"); //только один оператор должен быть true
Console.WriteLine($"false ^ false = {isFalse ^ isFalse}");


//тернарный оператор -  условие ? выражение1 : выражение2
Console.WriteLine();
int x = 5;
int y = 7;

int z = x > y ? x + 1 : y - 2;

Console.WriteLine($"z = {z}");

Console.WriteLine();

Console.Write("Enter 1th number: ");
x = int.Parse(Console.ReadLine());
Console.Write("Enter 2nd number: ");
y = int.Parse(Console.ReadLine());

int n = x <= y ? x : y;

while (n <= (x >= y ? x : y))
{
    Console.Write(n + "\t");

    //четные не делятся на 3
    if (n % 2 == 0 && n % 3 != 0)
    {
        Console.Write(n);
    }
    Console.Write("\t");

    //делятся на 5 и на 3
    if (n % 5 == 0 || n % 3 == 0)
    {
        Console.Write(n);
    }
    Console.Write("\t");

    //делится либо на 5 либо на 3, но не одновременно
    if (n % 5 == 0 ^ n % 3 == 0)
    {
        Console.Write(n);
    }
    n++;
    Console.WriteLine();
    
}


Console.WriteLine();
if (y > x && y > 10 && y % 2 == 0)
{
    Console.WriteLine(y);
}

Console.Write("Enter a number: ");
int k = int.Parse(Console.ReadLine());

if ((k < x && k > y) || (k > y && k < x))
{
    Console.WriteLine(k);
}
