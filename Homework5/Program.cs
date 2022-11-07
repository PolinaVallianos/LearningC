int number1;
int number2;

Console.WriteLine("Enter number1: ");
number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number2: ");
number2 = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = number1; i <= number2; i++)
{
    for (int j = number1; j <= number2; j++)
    {
        if (i!= j && (i + j) % 3 == 0)
        {
            sum = i + j;
            Console.WriteLine($"{i} + {j} = {sum}");
        }
    }
}

int sum1 = 0;

for (int i = number1; i <= number2; i++)
{
    sum1 += i;
}
Console.WriteLine($"Sum = {sum1}");