using System;

namespace Homework10;
class Program
{
    static void Main(string[] args)
    {
        string string1 = @"String escape sequences. Sequence, Character name, Unicode encoding. \', Single quote, 0x0027. \"", Double quote, 0x0022. \\, Backslash, 0x005C. \0, Null, 0x0000. \n, New line, 0x000A. \t, Horizontal tab, 0x0009";
        string string2 = "Currency codes. Char, Escape sequence, HTML code, Description. \u0024, \\u0024, &#36, dollar. \u00A2, \\u00A2, &#162, cent. \u00A3, \\u00A3, &#163, pound. \u20BD, \\u20BD, &#8381, ruble";
        string string3 = "List of companies.Company,Contact,Country.Alfreds Futterkiste,Maria Anders,Germany.Centro comercial Moctezuma,Francisco Chang,Mexico.Ernst Handel,Roland Mendel,Austria.Island Trading,Helen Bennett,United Kingdom.Laughing Bacchus Winecellars,Yoshi Tannamuri,Canada.Magazzini Alimentari Riuniti,Giovanni Rovelli,Italy.";

        PrintTable(string1);
        PrintTable(string2);
        PrintTable(string3);
    }

    static void PrintTable(string str)
    {
        string[] splitStr = str.Trim('.', ' ').Split('.');
        Console.WriteLine(splitStr[0].ToUpper());

        string[][] newString = new string[splitStr.Length - 1][];
        for (int i = 0; i < splitStr.Length-1; i++)
        {
            string[] line = splitStr[i + 1].Trim('.', ' ').Split(',');
            for (int j = 0; j < line.Length; j++)
            {
                newString[i] = line;
            }
        }

        PrintLine(newString);

        for (int i = 0; i < newString.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < newString[i].Length; j++)
            {
                Console.WriteLine("| " + newString[i][j].Trim('.', ' ') + " ");
                count = newString[i][j].Trim(' ').Length;

                if (count < MaxLength(newString, j))
                {
                    while (count < MaxLength(newString, j))
                    {
                        Console.Write(" ");
                        count++;
                    }
                }
            }

            if (i == 0)
            {
                Console.Write("|\n");
                PrintLine(newString);
            }
            else
            {
                Console.Write("|\n");
            }
        }

        PrintLine(newString);
        Console.WriteLine();
    }

    static void PrintLine(string[][] str)
    {
        int count = 0;
        int length = 0;

        for (int i = 0; i < str[0].Length; i++)
        {
            length += MaxLength(str, i) + 3;
        }

        while (count <= length)
        {
            Console.Write("-");
            count++;
        }
        Console.Write("\n");
    }

    static int MaxLength(string[][] str, int index)
    {
        int maxLength = 0;
        for (int i = 0; i < str.Length; i++)
        {
            maxLength = maxLength >= str[i][index].Trim().Length ? maxLength : str[i][index].Trim().Length;
        }
        return maxLength;
    }
}
