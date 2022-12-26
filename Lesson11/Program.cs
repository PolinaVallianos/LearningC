namespace Lesson11;
class Program
{
    static void Main(string[] args)
    {
        //Отличие бууквальных строк от необработанных
        string str1;
        str1 = @"\files\""My files""\";
        str1 = """\files\"My files"\""";

        string name = "Pi number";
        float pi = 3.1415f;

        str1 = $@"{{{name}}} = {pi}";
        str1 = $"""{name} = {pi}""";

        //        str1 = $@";
        //config {{
        //    {{name}}: ""{name}"
        //    { { value} }: ""{pi} ""
        //}}";


        //        str1 = $$"""
        //        config {
        //            {name}: "{{name}}"
        //            {value}: "{{pi}}"
        //        }
        //        """;


        //------------------------


        str1 = "Abcdefgh";
        string str2 = "Cities of Montenegro: Podgorica, Bar, Cetine. Podgorica is thee capital. (podgorica)";

        //проверяет содержит ли строка символ или подствроку
        Console.WriteLine("\n--Contains");

        bool ContainceA = Contains('A'); //True
        
        if (str2.Contains("Bar"))
        {
            Console.WriteLine("Bar is in Montenegro");
        }

        bool containceAnyText = str1.ToLower().Contains("any text");

        //заменяет символ или подстроку на новые
        Console.WriteLine("\n-----Replace");

        Console.WriteLine(str2.Replace(' ', '_'));
        Console.WriteLine(str2.Replace("Podgorica", "Cetine"));

        //Проверяет начинается ли строка с символа тлт подстроки
        Console.WriteLine("\n---StraWitch");

        Console.WriteLine("str1 start with Abc = " + str1.StartWith("Abc"));

        string[] splitStr = str2.Split();

        foreach (var item in splitStr)
        {
            if (item.ToLower().Trim().StartsWith('c'))
            {
                Console.WriteLine(item);
            }
        }

        //проверяет заканчивается ли строка на символ или подстроку
        Console.WriteLine("\n---EndWith");

        foreach (var item in splitStr)
        {
            if (item.ToLower().Trim().EndsWith('.'))
            {
                Console.WriteLine(item);
            }
        }

        //возращают позицию подстроки или символа. Если не найдено, вернет -1
        Console.WriteLine("\n---IndexOf & LastIndeexOf");

        Console.WriteLine(str1.IndexOf('G'));
        Console.WriteLine(str1.IndexOf('g'));

        //найти слово "Bar" и удалить его
        Console.WriteLine(str2.Remove(str2.IndexOf("Bar"), 5));

        Console.WriteLine(str2.LastIndexOf("Podgorica"));

        int numberOf_i = 0;
        int startIndex = 0;

        while (str2.IndexOf('i', startIndex) > 0)
        {
            startIndex = str2.IndexOf('i', startIndex);
            Console.WriteLine(startIndex);
            startIndex++;
            numberOf_i++;

        }

        Console.WriteLine("Number of 'i' = " + numberOf_i);
        Console.WriteLine();
        Console.WriteLine(RemoveAll(str2, "Podgorica"));

        string RemoveAll(string input, string target)
        {
            string result = input;

            for (int i = 0; (i = result.ToLower().IndexOf(target.ToLower(), i)) > 0;)
            {
                result = result.Remove(i, target.Length);
            }

            return result;
        }

        //объединяет элементы последова ельности(массива) в строку
        Console.WriteLine("\n---Join");

        string newStringFromArray = String.Join(' ', splitStr);

        Console.WriteLine(newStringFromArray);
        Console.WriteLine();

        int[] intArr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(String.Join(", ", intArr));

        string str3 = String.Join("", str2.Split(',', '.', ':', '(', ')'));
        Console.WriteLine(str3);

        //дополняют строку пробелами до указанной длины
        Console.WriteLine("\n--- PadLeft & PadRight");
        Console.WriteLine(str1.PadRight(10) + '|'));
        Console.WriteLine(str1.PadLeft(10) + '|'));
        Console.WriteLine(str1.PadRight(5) + '|'));

        //то же самое с помощью форматирования
        Console.WriteLine($"{str1,-10}|");//пробелы справа
        Console.WriteLine($"{str1,10}|");//пробелы слева
    }
}

