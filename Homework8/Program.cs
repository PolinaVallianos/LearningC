namespace Homework8;
class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = { 23, 12, 6, 13, 45, 123, 5 };
        float[] arr2 = { 1.7F, 12F, 3.14F, 34.678F, 2F, 73F };
        int[] arr3 = { 17, 45, 12, 13, 0 };

        

        Console.WriteLine(Sum(arr1));
        Console.WriteLine(Sum(arr2));

        

        Console.WriteLine(Max(arr1));
        Console.WriteLine(Max(arr2));

        

        Console.WriteLine(Average(arr1));
        Console.WriteLine(Average(arr2));

        


        Console.WriteLine(Contact(arr1, arr3));
    }

    //№1
    static int Sum(int[] array)
    {
        int sumInt;
        foreach (int item in array)
        {
            sumInt += item;
        }
        return sumInt;
    }


    static float Sum(float[] array)
    {
        float sumFloat = 0;
        foreach (float item in array)
        {
            sumFloat += item;
        }
        return sumFloat;
    }
    //№2
    static int Max(int[] array)
    {
        int MaxInt = 0;
        foreach (int item in array)
        {
            if (item > MaxInt)
            {
                MaxInt = item;
            }
        }
        return MaxInt;
    }

    static float Max(float[] array)
    {
        int MaxFloat = 0;
        foreach (float item in array)
        {
            if (item > MaxFloat)
            {
                MaxFloat = item;
            }
        }
        return MaxFloat;
    }
    //№3

    static float Average(float[] array)
    {
        
        return Sum(array) / array.Length;
    }
    //№4
    string[] Contact(int[] array, int[] array1)
    {
        string[] newArray = new string[array.Length + array1.Length];

        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i] + " " + array[i];
        }

        for (int i = 0 + array.Length; i < array1.Length; i++)
        {
            newArray[i] = array1[i] + " " + array1[i];
        }

        return newArray;

        for (int i = newArray.Length; i > 0; i--)
        {
            Console.Write(newArray[i] + " ");
        }
    }
}

