namespace Lesson10;
class Program
{
    static void Main(string[] args)
    {
        string str1 = "new";
        string str2 = "string";

        //конкатенация
        str2 = str1 + " " + str2;

        //строки не изменяемы
        str2 += str1;
        Console.WriteLine(str2);

        //управляющие последовательности
        //\n - новая строка
        //\t - горизонтальный отступ
        // \\ - обратная косая черта
        // \" - кавычка
        // \u - символ юникода в шестнадцатиричном формате

        str2 = "Happy New Year!";
        str2 += "\n\\\"\t\u2744\u2744\u2744\t\"\\";
        Console.WriteLine(str2);

        //бууквальные строки
        str1 = @"\user1\Picteres\
новая строка
не работуют управляющие символы \n\t\u2744";

        Console.WriteLine(str1);

        //необнавленные строки
        Console.WriteLine("""
        First string
            Second string
                Second string 1
                Second string 2
            Third string
        Four string

        """);


        int a = 3;
        int b = 2;
        //Интерполяция - вставка в текст различных выражений
        Console.WriteLine("\n--Интерполяция");
        Console.WriteLine($"{a}-{b}={a-b}");

        //Составное форматирование
        Console.WriteLine("{0}-{1}={2}", a, b, a-b);
        Console.WriteLine("{0}-{1}={2}",
            a,
            b,
            a-b);

        Console.WriteLine("\n--Форматирование");
        Console.WriteLine("{0}", Math.Sqrt(a));
        Console.WriteLine("{0:##.###}", Math.Sqrt(a));
        Console.WriteLine("{0:##}", Math.Sqrt(a));
        Console.WriteLine("{0:E}", Math.Sqrt(a) * 1000);
        Console.WriteLine("{0:E3}", Math.Sqrt(a) * 1000);
        Console.WriteLine();

        double d = Math.Sqrt(a) * 1000;

        Console.WriteLine($"{d:##.###}");
        Console.WriteLine($"{d:E5}");

        Console.WriteLine(d);
        Console.WriteLine(d.ToString("#"));
        Console.WriteLine(d.ToString("#.##"));
        Console.WriteLine(d.ToString("E4"));

        Console.WriteLine("\n--Символы");

        char ch1 = 'a';
        char ch2 = '\u2744';

        Console.WriteLine(ch2);

        int ch1Code = ch1;
        int ch2Code = ch2;
        Console.WriteLine(ch2Code);//код снежинки в десят.
        Console.WriteLine(ch2Code.ToString("X"));//код снежинки

        //строка - это массив символов
        Console.WriteLine("\n -- Строка массив символов");

        string str3 = "Abcdef";
        foreach (var item in str3)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n");
        Console.WriteLine("Char\tDecCode\tHexCode");

        foreach (var item in str3)
        {
            int chCode = item;
            Console.WriteLine($"{item}\t{chCode}\t{chCode:X}");
        }

        Console.WriteLine();
        Console.WriteLine("str3.Length = " + str3.Length);
        for (int i = str3.Length-1; i >= 0; i--)
        {
            Console.WriteLine(str3[i]);
            //str3[i] = 'd'; //изменять нельзя
        }

        Console.WriteLine();
        Console.WriteLine("\n--Методы работы со строками");

        Console.WriteLine("str3.ToUpper() = " + str3.ToUpper());
        Console.WriteLine("str3.ToLower() = " + str3.ToLower());

        string str4 = "Cities of Montenegro: Podgorica, Bar, Cetine. Podgorica is thee capital.";


        //получение подстроки
        Console.WriteLine("\n--Substrings");
        Console.WriteLine(str4.Substring(46));
        Console.WriteLine(str4.Substring(46, 9));

        //Удаление подстроки
        Console.WriteLine("\n -- Remove");
        Console.WriteLine(str4.Remove(46));
        Console.WriteLine(str4.Remove(46, 9));
        //вставка подстроки
        Console.WriteLine("\n -- Insert");
        Console.WriteLine(str4.Insert(44, ", Budva"));

        //разбиение строки на массив подстрок (разделитель по умолчанию пробел)

        Console.WriteLine("\n -- Split");
        string[] splitStr1 = str4.Split();
        foreach (var item in splitStr1)
        {
            //отсечение указанных символов
            Console.WriteLine(item.Trim(':', ',', '.'));
        }
        Console.WriteLine();

        string[] splitStr2 = str4.Split('.');
        foreach (var item in splitStr2)
        {
            //отсечение пробелов
            Console.WriteLine(item.Trim());
        }
        Console.WriteLine();
    }
}

