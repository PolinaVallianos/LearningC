//цикл do while, сначало выполяется внутри do, потом условие.

int n1 = 1;
int n2 = 100;
do
{
    n1 *= 2;
    Console.Write($"{n1} ");

} while (n1 <= 128);

n1 = 1;
while (n1 <= 128)
{
    n1 *= 2;
    Console.Write($"{n1} ");
}


n1 = 1;
Console.WriteLine("For cycle");


//for (инициализатор; условие (bool type); итератор)
//{
// тело цикла
//}

for (int i = n1; i <= 128; i *= 2)
{
    Console.Write($"{i} ");
}

Console.WriteLine();

for (; n1 < 128; n1 *= 2)
{
    Console.Write($"{n1} ");
}


Console.WriteLine();
n1 = 1;

for (; n1 < 128;)
{
    Console.Write($"{n1} ");
    n1 *= 2;
}


for (; ;)
{
    Console.Write($"{n1} ");
    n1 *= 2;
    if (n1 > 128)
    {
        break; //завершение цикла
    }
}


Console.WriteLine();
n1 = 1;
int sum = 0;

for (int i = n1; i < n2; i++)
{
    if (i % 2 == 0 && i % 4 != 0)
    {
    sum += i;
    }
}
Console.WriteLine(sum);

for (Console.WriteLine("Начало цикла: "); n1 < n2; Console.Write($"{n1 *= 2}"))
{

}


n1 = 1;
n2 = 100;

for (int i = n1, j = n2; i <= j; i++, j--)
{
    Console.Write($"\t{i}\t{j}\n");
}

Console.WriteLine("------------------");
Console.WriteLine("-----THE GAME-----");
Console.WriteLine("------------------");


var random = new Random();
int nWin = 10;

for (int i = 0, j = 0, count = 1; count <= 100;  count++)
{
    n1 = random.Next(1, 6);
    n2 = random.Next(1, 6);
    Console.Write($"{count}th");
    Console.Write($"\t{n1}\t{n2}\n");

    i += n1;
    j += n2;

    Console.Write($"Score\t{i}\t{j}\n");


    if (i > nWin)
    {
        if (j > nWin)
        {
            i /= 2;
            j /= 2;
            Console.Write($"Correct\t{i}\t{j}\n");
            continue;

        }
        Console.WriteLine($"Second player WINs!");
        break;
    }

    if (j > nWin)
    {
        Console.WriteLine($"First player WINs!");
        break;
    }

    if (i == nWin)
    {
        if (j == nWin)
        {
            i = j /= 2;
            Console.Write($"Correct\t{i}\t{j}\n");
            continue;
        }
        Console.WriteLine($"First player WINs!");
        break;
    }

    if (j == nWin)
    {
        Console.WriteLine($"Second player WINs!");
        break;
    }
}


Console.WriteLine("-----Таблица умножения-----");
Console.WriteLine();

for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\n----- SWIITCH -----\n");

Console.WriteLine("Введдите название блюда:\n (доступные варианты: суп, сок, пюре)");
string order = Console.ReadLine();

switch (order)
{
    case "суп":
        Console.WriteLine("Суп -- это отличный выбор");
        break;
    case "сок":
        Console.WriteLine("Сок всегда свежий");
        break;
    case "пюре":
        Console.WriteLine("Пюре уже готовится..");
        break;
    default:
        Console.WriteLine($"Извините, блюда \"{order}\"в меню нет");
        break;
}