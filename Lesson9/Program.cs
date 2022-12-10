﻿namespace Lesson9;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Многомерные массивы");
        int[,] arr21 = new int[2, 3]; //массив 2 х 3 элемента
        int[,] arr22 = new int[2, 3] {{ 1, 2, 3,}, { 3,4,5} };
        int[,] arr23 = new int[,] { { 1, 2, 3 }, { 3, 4, 5 } };
        int[,] arr24 = new [,] { { 1, 2, 3 }, { 3, 4, 5 } };

        //массив типа int[3,3]
        int[,] arr25 =
        {
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }
        };

        Console.WriteLine($"Трети элемент второй строки arr25 = {arr25[1,2]}");


        //размер массива
        Console.WriteLine($"arr25.Rank = {arr25.Rank}");

        //длина многомерного массива = кол-во элементов во всех измерениях
        Console.WriteLine($"Длина arr25 = {arr25.Length}");

        foreach (var item in arr25)
        {
            Console.Write(item + " ");
        }

        Console.Write("\n");

        for (int i = 0; i < 3; i++)
        {
            Console.Write("{");
            for (int j = 0; j < arr25.Length/3; j++)
            {
                Console.Write(arr25[i, j] + " ");
            }
            Console.WriteLine("}");

        }

        Console.WriteLine("\nТрехмерный массив");
        int[,,] arr30 = new int[3, 4, 5];

        for (int i = 0; i < arr30.GetLength(0); i++)
        {
            Console.Write("{");
            for (int j = 0; j < arr30.GetLength(1); j++)
            {
                Console.Write("{");
                for (int k = 0; k < arr30.GetLength(2); k++)
                {
                    Console.Write($"{arr30[i, j ,k] = i + j + k}");
                }
                Console.Write("}");
            }
            Console.Write("}");
        }
        Console.WriteLine("Длина arr30 = " +
            arr30.GetLength(0) + " x " +
            arr30.GetLength(2) + " x " +
            arr30.GetLength(0) + " x " +
            arr30.Length
            );

        foreach (var item in arr30)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n");
        Console.WriteLine("Массив массивов или Зубчатый массив");

        int[][] arr40 = new int[5][];//массив arr40 содержит 5 массивов типа int
        int[][] arr41 =
        {
            new int[] {1,3,5},
            new int[4],
            new int[] {2,12, 3}
        };


        int[] arr1 = { 12, 13, 14 };
        int[] arr2 = new int[4];

        arr40[0] = arr1;//массив arr40[0] ссылается на ту же область памяти, что и arr1
        arr40[1] = new[] { 2, 3, 5, 6, 7, 8 };
        arr40[2] = arr2;
        arr40[3] = new int[3];
        arr40[4] = new int[5];

        Console.WriteLine("Длина массива arr40 = " + arr40.Length);
        Console.WriteLine("Длина массива arr40[1] = " + arr40[1].Length);

        arr40[3][2] = 23;
        arr40[3][0] = 12;

        foreach (var arr in arr40)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        for (int i = 0; i < arr40.Length; i++)
        {
            for (int j = 0; j < arr40[i].Length; j++)
            {
                Console.Write(arr40[i][j] + " ");
            }
            Console.WriteLine();
        }

        //Массив массивов массивов типа int
        int[][][] arr50 = new int[3][][];

        for (int i = 0; i < arr50.Length; i++)
        {
            arr50[i] = new int[i + 3][];
            for (int j = 0; j < arr50[i].Length; j++)
            {
                arr50[i][j] = new int[j + 4];

                for (int k = 0; k < arr50[i][j].Length; k++)
                {
                    arr50[i][j][k] = k;
                }
            }
        }

        foreach (var arrA in arr50)
        {
            foreach (var arrB in arrA)
            {
                foreach (var item in arrB)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\t");
            }
            Console.WriteLine("\t");

        }

        for (int i = 0; i < arr50.Length; i++)
        {
            Console.WriteLine($"Массив arr[{i}]");
            for (int j = 0; j < arr50[i].Length; j++)
            {
                Console.Write("\t");
                Console.WriteLine($"Массив arr[{i}][{j}]");

                for (int k = 0; k < arr50[i][j].Length; k++)
                {
                    Console.Write(arr50[i][j][k] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}

