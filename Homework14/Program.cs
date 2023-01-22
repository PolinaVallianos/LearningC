using System.Linq;

namespace Homework14;
class Program
{
    static void Main(string[] args)
    {
        int minNumber, maxNumber;
        int[] test = {1, 2, 5, 7};
        int length = 8;
        bool result = false;
        int characters = 0;

        (minNumber, maxNumber) = GetMinMax(75, 8, 12, 12, 3, 100);
        Console.WriteLine($"Min = {minNumber}, Max = {maxNumber}");

        (minNumber, maxNumber) = GetMinMax(1, 3, 67, 2, 32);
        Console.WriteLine($"Min = {minNumber}, Max = {maxNumber}");

        (result, characters) = Expand(test, length);
        Console.WriteLine($"\n{result}, Number of items added: {characters}");

        if (result == true)
        {
            int[] newArray = new int[length];

            for (int i = 0; i < test.Length; i++)
            {
                newArray[i] = test[i];
            }

            for (int j = 1, k = 0; k < characters; j++, k++)
            {
                newArray[test.Length + k ] = j;
            }

            for (int i = 0; i < newArray.Length-1; i++)
            {
                Console.Write(newArray[i] + ", ");
            }
            Console.Write(newArray[newArray.Length-1] + "\n");
        }

    }

    static (int, int) GetMinMax(params int[] numbers)
    {
        int[] result = new int[2];
        int bigNumber = 0;

        foreach (var item in numbers)
        {
            if (item >= bigNumber)
            {
                bigNumber = item;
            }
        }

        int smallNumber = bigNumber;

        foreach (var item in numbers)
        {
            if (item <= smallNumber)
            {
                smallNumber = item;
            }
        }
        return (smallNumber, bigNumber);
    }

    static (bool, int) Expand(int[] array, int length)
    {
        bool result = false;
        int characters = 0;

        if (length > array.Length)
        {
            result = true;
            characters = length - array.Length;
        }
        return (result, characters);
    }
}

