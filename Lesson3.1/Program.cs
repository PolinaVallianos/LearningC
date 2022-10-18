string input;
int number;
bool isEven;
Console.WriteLine("Enter the number: ");
input = Console.ReadLine();
number = int.Parse(input);

if (number%2 !=  0)
{
    isEven = false;
    Console.WriteLine($"The number {number} isn't even");
}
else
{
    isEven = true;
    Console.WriteLine($"The number {number} is even");
}

Console.ReadLine();