int number1;
int number2;

Console.WriteLine("Enter number1: ");
number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number2: ");
number2 = int.Parse(Console.ReadLine());

int nBig = number1 > number2 ? number1 : number2;
int nSmal = number1 > number2 ? number2 : number1;

int sum = 0;

for (int i = nSmal; i <= nBig; i++)
{
    for (int j = nSmal; j <= nBig; j++)
    {
        if (i!= j && (i + j) % 3 == 0)
        {
            sum = i + j;
            Console.WriteLine($"{i} + {j} = {sum}");
        }
    }
}

int sum1 = 0;

for (int i = nSmal; i <= nBig; i++)
{
    sum1 += i;
}
Console.WriteLine($"Sum = {sum1}");


for (int i = 1; i <= nBig; i++)
{
    int sumDelittle = 0;
    int delittle = 1;
    while (delittle < i)
    {
        if (i % delittle == 0)
        {
            sumDelittle += delittle;
        }

        delittle++;
    }
    if (sumDelittle == i)
    {
        Console.WriteLine($"{i}");
    }
}