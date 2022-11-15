while (true)
{
    Console.WriteLine("Enter program numbre: ");
    var n1 = Console.ReadLine();

    switch (n1)
    {
        case "1":
            Console.WriteLine($"Task {n1}");
            int start = GetIntNumber();
            int numberTask1 = GetIntNumber();
            Console.WriteLine(Task1(start, numberTask1));
            break;
        case "2":
            Console.WriteLine($"Task {n1}");
            int numberTask2 = GetIntNumber();
            Task2(numberTask2);
            break;
        case "3":
            Console.WriteLine($"Task {n1}");
            int numberTask3 = GetIntNumber();
            Task3(numberTask3);
            break;
        case "4":
            Console.WriteLine($"Task {n1}");
            int numberTask4 = GetIntNumber();
            Task4(numberTask4);
            break;
        case "q" or "Q":
            Console.WriteLine($"Bye, bye!");
            return;
        default:
            Console.WriteLine($"Task {n1} doesn't exist");
            break;
    }
}






int Task1(int start, int number)
{
    int numbers = 0;
    for (int i = start; number > 0; i++)
    {
        
        if (i % 2 != 0 && i % 3 == 0)
        {
            Console.Write($"{i} ");
            number--;
            numbers += i;
        }
    }
    Console.WriteLine();
    return numbers;
}

void Task2(int number)
{
    for (int i = 1; i <= number; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{j}");
        }
        Console.WriteLine();
    }
}

void Task3(int number)
{
    for (int i = 1; i <= number; i++)
    {
        for (int j = number - 1; j >= i; j--)
        {
            Console.Write($" ");
            
        }
        for (int k = 1; k <= i; k++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}

void Task4(int number)
{
    for (int i = 1; i <= number; i++)
    {
        for (int j = number - 1; j >= i; j--)
        {
            Console.Write($" ");

        }
        for (int k = 0; k <= i; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

int GetIntNumber()
{
    Console.WriteLine("Enter the number");
    return int.Parse(Console.ReadLine());

}