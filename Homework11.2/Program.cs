using System.Text;

namespace Homework11._2;
class Program
{
    static void Main(string[] args)
    {
        string str1 = "Abcdefgh";
        string str2 = "Cities of Montenegro: Podgorica, Bar, Cetine. Podgorica is the capital. (podgorica)";

        int maxLeength = 0;

        foreach (var item in str2.Split())
        {
            Console.WriteLine(item);
            maxLeength = maxLeength > item.Length ? maxLeength : item.Length;
        }

        Console.WriteLine();

        //дополняем пробелами слева
        foreach (var item in str2.Split())
        {
            Console.WriteLine(item.PadLeft(maxLeength));
        }

        //выравнивание по центру
        foreach (var item in str2.Split())
        {
            Console.WriteLine('|' +
                (item.
                    PadLeft(maxLeength - (maxLeength - item.Length) / 2)).
                    PadRight(maxLeength)+
                '|');
        }

        //TrimSplit и TrimEnd - обрезают строкуу сначала и в конце

        //преобразует строку в массив символов
        Console.WriteLine("\n---ToCharArray");

        char[] charArray1, charArray2;

        charArray1 = str1.ToCharArray();
        charArray2 = str2.ToCharArray(2, 4);
        Console.WriteLine(String.Join(' ', charArray2));

        //дополнительные конструкторы строк
        Console.WriteLine("\n---new String: ");

        string str3, str4;

        //создание строки из массива символов
        str3 = new string(charArray2);

        str4 = new string(charArray1, 2, 4);

        Console.WriteLine(str3 == str4);

        //создает строку из повторяющихся символов

        str4 = new string('-', 20);
        Console.WriteLine(str4);

        //проверяет является ли строка пустой или не инициализированной
        Console.WriteLine("\n---IsNullOrEmpty");

        str4 = "";

        if (String.IsNullOrEmpty(str4) == false)
        {
            Console.WriteLine("str4 is not empty: " + str4);
        }


        //
        str4 = " \n\t";

        if (String.IsNullOrWhiteSpace(str4) == false)
        {
            Console.WriteLine("str4 is not empty: " + str4);
        }

        //класс StringBuilder
        Console.WriteLine("\n---StringBuilder: ");

        StringBuilder sb = new StringBuilder();
        sb = new StringBuilder("Hello, world!");

        str4 = sb.ToString();
        Console.WriteLine(sb);

        //длина и ёмкость
        Console.WriteLine("sb.Length = " + sb.Length);
        Console.WriteLine("sb.Capacity = " + sb.Capacity);

        //добавление строки в конец
        sb.Append(" Podgorica.");

        Console.WriteLine(sb);
        Console.WriteLine("sb.Length = " + sb.Length);
        Console.WriteLine("sb.Capacity = " + sb.Capacity);

        Console.WriteLine();

        //очищает хранимое значение
        sb.Clear();
        sb.Append("Podgorica");
        Console.WriteLine(sb);
        Console.WriteLine("sb.Length = " + sb.Length);
        Console.WriteLine("sb.Capacity = " + sb.Capacity);

        sb = new StringBuilder(50);
        sb.Append("Podgorica");
        Console.WriteLine(sb);
        Console.WriteLine("sb.Length = " + sb.Length);
        Console.WriteLine("sb.Capacity = " + sb.Capacity);

        //чтение и запись файлов
        Console.WriteLine("\n---Class File: ");

        string filePath = @"input.txt";

        string input = File.ReadAllText(filePath);
        input = File.ReadAllText(@"input.txt");

        Console.WriteLine(input);

        string[] strings = File.ReadAllLines(filePath);
        foreach (var item in strings)
        {
            Console.Write(item + " ");
        }

        string outPath = @"Data/output.txt";
        //запись строки в файл
        //File.WriteAllText(outPath, input);

        //запись массива строк в файл
        File.WriteAllLines(outPath, strings);

        File.AppendAllText(outPath, "\n New text\n");

        File.AppendAllLines(outPath, strings);
    }

}

