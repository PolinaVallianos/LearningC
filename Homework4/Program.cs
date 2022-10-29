int number1;
int number2;
int number3;

Console.WriteLine("Enter integer number1: ");
number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter integer number2: ");
number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter integer number3: ");
number3 = int.Parse(Console.ReadLine());

int smalest;
int middle;
int biggest;
int smalest1;

if (number1 == number2 || number1 == number3 || number2 == number3)
{
    if (number1 == number2 && number2 == number3)
    {
        Console.WriteLine($"{number1} = {number2} = {number3}");
        smalest1 = number1;
        middle = number2;
        biggest = number3;
    }
    else
    {
        if (number1 == number2)
        {
            if (number1 > number3)
            {
                Console.WriteLine($"{number3} < {number1} = {number2}");
                smalest1 = number3;
                middle = number1;
                biggest = number2;
            }

            else
            {
                Console.WriteLine($"{number1} = {number2} < {number3}");
                smalest1 = number1;
                middle = number2;
                biggest = number3;
            }
        }

        if (number1 == number3)
        {
            if (number1 > number2)
            {
                Console.WriteLine($"{number2} < {number1} = {number3}");
                smalest1 = number2;
                middle = number1;
                biggest = number3;
            }

            else
            {
                Console.WriteLine($"{number1} = {number3} < {number2}");
                smalest1 = number1;
                middle = number3;
                biggest = number2;
            }
        }

        else
        {
            if (number2 > number1)
            {
                Console.WriteLine($"{number1} < {number2} = {number3}");
                smalest1 = number1;
                middle = number2;
                biggest = number3;
            }

            else
            {
                Console.WriteLine($"{number2} = {number3} < {number1}");
                smalest1 = number2;
                middle = number3;
                biggest = number1;
            }
        }
    }
}
else
{

    smalest = number1 < number2 ? number1 : number2;
    smalest1 = smalest < number3 ? smalest : number3;


    if (number2 > smalest1 & number2 < number3)
    {
        middle = number2;
        biggest = number3;
    }
    else
    {
        biggest = number2;
        middle = number3 > number1 ? number3 : number1;
    }

    Console.WriteLine($"{smalest1} < {middle} < {biggest}");
}


int countsmall = smalest1;
while (countsmall < middle)
{
    Console.Write($"{countsmall++}, ");
}
Console.Write($"{middle} \n");

int countbiggest = biggest;
while (middle < countbiggest)
{
    Console.Write($"{countbiggest--}, ");
}
Console.Write($"{middle} \n");

int count = smalest1;
int countNumbers = 0;
while (count <= middle)
{
    if ((count % 2 == 0) && (count % 4 != 0))
    {
        countNumbers++;
    }
    count++;
}
Console.WriteLine($"{countNumbers}");


int sum = 0;
while (smalest1 <= biggest)
{
    if (smalest1 % 7 == 0 ^ smalest1 % 3 == 0)
    {
        sum += smalest1;
    }
    smalest1++;
}
Console.WriteLine(sum);