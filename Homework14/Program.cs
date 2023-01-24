using System.Linq;
using static System.Net.Mime.MediaTypeNames;

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

        (result, characters) = Expand(ref test, length);
        Console.WriteLine($"\n{result}, Number of items added: {characters}");

        if (result == true)
        {
            for (int i = 1, j = test.Length - characters; j < test.Length; i++, j++)
            {
                test[j] = i;
            }

            Console.WriteLine(String.Join(", ", test));
        }

    }

    static (int, int) GetMinMax(params int[] numbers)
    {
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

    static (bool, int) Expand(ref int[] array, int length)
    {
        bool result = false;
        int characters = 0;

        if (length > array.Length)
        {
            int[] newArray = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            result = true;
            characters = length - array.Length;
            array = newArray;
        }
        return (result, characters);
    }
}

