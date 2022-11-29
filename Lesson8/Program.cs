namespace Lesson8;
class Program
{
    static void Main(string[] args)
    {
        //Массивы - это абор данных одного типа
        int[] arr0; // значение не инициализированно
        int[] arr1 = new int[4]; //значения по умолчанию: 0, 0, 0, 0
        int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
        int[] arr3 = new int[] { 1, 2, 3, 4 }; //автоопределение длины массива
        int[] arr4 = new[] { 1, 2, 3, 4, 5, 6 };
        int[] arr5 = { 1, 2, 3, 4, 5 };

        //arr0 = { 1, 2, 3 }; - так нельзя
        arr0 = new[] { 1, 2, 3 };

        //массив неизменяемый!

        // массивы начинаются с нуля!
        arr0[0] = 12;
        arr0[1] = 13;

        Console.WriteLine($"Длина массива arr3 = {arr3.Length}");

        //arr3[4] = 13; выход за пределы массива

        for (int i = 0; i < arr0.Length; i++)
        {
            arr0[i] = i;
        }

        //только для чтения. Нельзя изменить зачение "item"
        foreach (var item in arr0)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n");

        //Массивы - ссылочные типы
        arr1 = arr5; // arr1 ссылается на ту же область памяти, что и arr5
        arr5[4] = 14;
        Console.WriteLine($"arr1[4] = {arr1[4]}");

        //при передачи массива в функцию его элементы можно изменить

        void CleanArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }


        CleanArray(arr1);
        Console.WriteLine("\nAfter cleaning:");

        foreach (var item in arr5)
        {
            Console.Write(item + " ");
        }

        //Массив можно вернуть из функции

        string[] strArray = new string[3];


        //запись значений массив из консоли
        for (int i = 0; i < strArray.Length; i++)
        {
            Console.WriteLine("Введите строку");
            strArray[i] = Console.ReadLine();
        }


        string[] Twice(string[] oldAddray)
        {
            string[] newArray = new string[oldAddray.Length];

            for (int i = 0; i < oldAddray.Length; i++)
            {
                newArray[i] = oldAddray[i] + " " + oldAddray[i];
            }

            return newArray;
        }

        foreach (var item in Twice(strArray))
        {
            Console.WriteLine(item);
        }
    }
}

