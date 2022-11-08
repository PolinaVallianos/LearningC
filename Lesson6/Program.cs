int n1 = 0;
int n2 = 0;
int n3 = 0;

Console.WriteLine("Enter program numbre: ");
n1 = int.Parse(Console.ReadLine());

switch (n1)
{
    case 1:
        Console.WriteLine($"Program {n1}");
        Console.WriteLine(Program1(n1, "FirstProgram"));
        break;
    case 2:
        Console.WriteLine($"Program {n1}");
        Program2(n1, "SecondProgram");
        break;
    case 3:
        Console.WriteLine($"Program {n1}");
        Program3(n1);
        break;
    case 4:
        Console.WriteLine($"Program {n1}");
        Program4();
        break;
    case 5:
        Console.WriteLine();
        n1 = GetIntNumber();
        n2 = GetIntNumber();
        Program5(n1, n2);
        Program6(n1, n2);
        break;
    default:
        Console.WriteLine($"Program {n1} doesn't exist");
        break;
}

//Функция - именовонный блок программы

string Program1(int programNumber, string name)
{
    return $"Program {programNumber}: {name}";

}


void Program2(int programNumber, string name)
{
    Console.WriteLine($"Program {programNumber}: {name}");
}

void Program3(int number)
{
    switch (number)
    {
        case < 0:
            Console.WriteLine($"{number} < 0");
            break;
        case < 10:
            Console.WriteLine($"0 < {number} < 10");
            break;
        case < 100:
            Console.WriteLine($"10 < {number} < 100");
            break;
        default:
            Console.WriteLine($"{number} out of the range");
            break;

    }

    switch (number)
    {
        case < 0:
        case > 100:
            Console.WriteLine($"{number} out of the range");
            break;
        case < 10:
            Console.WriteLine($"0 < {number} < 10");
            break;
        default:
            Console.WriteLine($"10 < {number} < 100");
            break;
    }
}

void Program4()
{

    Console.WriteLine("Enter three number: ");
    n1 = GetIntNumber();
    n2 = GetIntNumber();
    n3 = GetIntNumber();

    switch (n1)
    {
        case > 0 when n1 < n2 && n1 < n3:
            Console.WriteLine($"{n1} < {n2} < {n3}");
            break;
        case > 0 when n1 < n2 && n2 > n3:
            Console.WriteLine($"{n1} < {n3} < {n2}");
            break;
        case > 0 when n1 > n2 && n2 < n3:
            Console.WriteLine($"{n2} < {n1} < {n3}");
            break;
        case > 0 when n1 > n2 && n2 > n3:
            Console.WriteLine($"{n1} > {n2} > {n3}");
            break;
    }
}

int GetIntNumber()
{
    Console.WriteLine("Enter the number");
    return int.Parse(Console.ReadLine());

}

void Program5(int number1, int number2)
{
    Console.WriteLine("Polina");
    int sum = 0;
    for (int i = number1; i <= number2; i++)
    {
        for (int j = number1; j <= number2; j++)
        {
            if (i != j && (i + j) % 3 == 0)
            {
                sum = i + j;
                Console.WriteLine($"{i} + {j} = {sum}");
            }
        }
    }
}

void Program6(int number1, int number2)
{
    Console.WriteLine("Variant 1");

    for (int i = number1; i <= number2; i++)
    {
        for (int j = i + 1; j <= number2; j++)
        {
            if ((i + j) % 3 == 0 )
            {
                Console.WriteLine($"{i} + {j} = {i + j}");
            }
        }
    }


    Console.WriteLine("Variant 2");

    for (int i = number1; i <= number2; i++)
    {
        for (int j = number2; j > i; j--)
        {
            if ((i + j) % 3 == 0)
            {
                Console.WriteLine($"{i} + {j} = {i + j}");
            }
        }
    }
}