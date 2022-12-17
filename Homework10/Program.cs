using System;

namespace Homework10;
class Program
{
    static void Main(string[] args)
    {
        string string1 = @"String escape sequences. Sequence, Character name, Unicode encoding. \', Single quote, 0x0027. \"", Double quote, 0x0022. \\, Backslash, 0x005C. \0, Null, 0x0000. \n, New line, 0x000A. \t, Horizontal tab, 0x0009";
        string string2 = "Currency codes. Char, Escape sequence, HTML code, Description. \u0024, \\u0024, &#36, dollar. \u00A2, \\u00A2, &#162, cent. \u00A3, \\u00A3, &#163, pound. \u20BD, \\u20BD, &#8381, ruble";

        PrintTable(string1);
        PrintTable(string2);
    }

    static void PrintTable(string str)
    {
        string[] splitStr = str.Split('.');

        //заголовок
        string Header = splitStr[0];
        Console.WriteLine(Header.ToUpper());

        //шапка таблицы
        string[] TableHeader = splitStr[1].Split(',');

        int number = 0;
        for (int i = 0; i < TableHeader.Length; i++)
        {
            number += TableHeader[i].Length + 2;
        }

        //горизонтальная линия
        for (int i = 0; i < number; i++)
        {
            Console.Write("-");
        }
        Console.Write("-\n");

        //шапка таблицы
        for (int i = 0; i < TableHeader.Length; i++)
        {
            Console.Write("|" + TableHeader[i] + " ");
            if (i == TableHeader.Length - 1)
            {
                Console.Write("|\n");
            }
        }

        //горизонтальная линия
        for (int i = 0; i < number; i++)
        {
            Console.Write("-");
        }
        Console.Write("-\n");

        //таблица

        for (int i = 2; i < splitStr.Length; i++)
        {
            string[] Table = splitStr[i].Split(',');

            for (int j = 0; j < Table.Length; j++)
            {
                Console.Write("|" + Table[j]);

                for (int k = 0; k < (TableHeader[j].Length + 2) - (Table[j].Length + 1); k++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("|");
        }

        //горизонтальная линия
        for (int i = 0; i < number; i++)
        {
            Console.Write("-");
        }
        Console.Write("-\n");
    }
}
