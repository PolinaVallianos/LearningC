namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = { 2, 4, 6, 3, 1 };
        int[] arr2 = { 2, 7, 6, 5 };
        int[] arr3 = { 3, 4, 6, 7, 1, 5 };
        int[,] arr4 = new int[2, 3];
        int[,] arr5 = new int[2, 3];
        int[][] arr6 = new int[3][] { arr1, arr2, arr3 };

        //1
        Revers(arr1);
        Console.WriteLine("\n");
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(arr1[i] + " ");
        }

        //2


        //1
        //static int[] Revers(int[] array)
        //{
        //    int[] newArray = new int[array.Length];

        //    for (int i = array.Length, j = 0; i > 0; i--, j++)
        //    {
        //        newArray[j] = array[i];
        //    }

        //    return newArray;

        //        for (int i = array.Length; i > 0; i--)
        //        {
        //            Console.Write(array[i] + " ");
        //        }
        //    }

        //2
        static int[] Remove(int[] array, int index)
        {

            if (index > array.Length - 1)
            {
                return array;
            }


            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

    }
}