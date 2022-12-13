namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = { 2, 4, 6, 3, 1 };
        int[] arr2 = { 2, 7, 6, 5 };
        int[] arr3 = { 3, 4, 6, 7, 1, 5 };
        int[,] arr4 = new int[3, 2];
        int[,] arr5 = new int[3, 2];
        int[][] arr6 = new int[3][] { arr1, arr2, arr3 };

        Console.WriteLine("В обратном порядке:");
        PrintArray(Revers(arr1));

        Console.WriteLine();
        PrintArray(arr1);

        Console.WriteLine("\nУдаление элемента 0:");
        PrintArray(Remove(arr1, 0));
        Console.WriteLine("\nУдаление элемента -1:");
        PrintArray(Remove(arr1, -1));
        Console.WriteLine("\nУдаление элемента 5:");
        PrintArray(Remove(arr1, 5));

        PrintArray2(Fill(arr4));

        PrintArray2(SumOfMatrix(arr4, Fill(arr5)));

        Console.WriteLine();
        PrintArray3(JaggedToMatrix(arr6));
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }

    static void PrintArray2(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void PrintArray3(int[][] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            PrintArray(array[i]);
            Console.WriteLine();
        }
    }

    //1
    static int[] Revers(int[] array)
    {
        int[] newArray = new int[array.Length];

        for (int i = array.Length - 1, j = 0; i >= 0; i--, j++)
        {
            newArray[j] = array[i];
        }

        return newArray;
    }

    //2
    static int[] Remove(int[] array, int index)
    {
        if (index > (array.Length - 1))
        {
            return array;
        }

        if (index < 0)
        {
            index += array.Length;
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index + 1; i < (array.Length - 1); i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        else
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0, j = 0; i < index; i++, j++)
            {
                newArray[j] = array[i];
            }

            for (int i = index + 1, j = 0; i < array.Length; i++, j++)
            {
                newArray[j] = array[i];
            }
            return newArray;
        }
    }
    //3
    static int[,] Fill(int[,] array)
    {
        int[,] newArray = array;

        for (int i = 0, k = 1; i < newArray.GetLength(0); i++, k++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                if (i == 0)
                {
                    Console.Write($"\nEnter the element of the first array: ");
                    newArray[i, j] = int.Parse(Console.ReadLine());
                    continue;
                }

                newArray[i, j] = newArray[i - 1, j] * k;
            }
        }
        return newArray;
    }

    //4
    static int[,] SumOfMatrix(int[,] array1, int[,] array2)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                array1[i, j] += array2[i, j];
            }
        }
        return array1;
    }

    //5
    static int[][] JaggedToMatrix(int[][] array)
    {
        int[][] newArray = new int[array.GetLength(0)][];
        int[] smallest = array[0];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            smallest = array[i].Length >= smallest.Length ? smallest : array[i];
        }

        int index = smallest.Length;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            while (array[i].Length > index)
            {
                array[i] = Remove(array[i], index);
            }
            newArray[i] = array[i];
        }
        return newArray;
    }
}
