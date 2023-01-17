namespace Lesson14;
class Program
{
    //Модификаторы параметров метода

    static void Main(string[] args)
    {
        int result;
        int a = 1, b = 2, c = 3, d = 4;
        result = Sum();
        Console.WriteLine(result);

        result = Sum(a, b);
        Console.WriteLine(result);

        result = Sum(a, b, c, d);
        Console.WriteLine(result);

        result = Sum(a, b, c, d, 12, 34, 54, 73);
        Console.WriteLine(result);

        string[] names = GetNames("Player", a, b, 34, 6, 83, 9);
        Console.WriteLine(string.Join("\n", names));

        Console.WriteLine("\n----- ref modifier -----"); //значение может быть изменено внутри метода

        Clamp(3, d);
        Console.WriteLine("d = " + d);

        Clamp(3, ref d);
        Console.WriteLine("d = " + d);

        Console.WriteLine("\n----- out modifier -----"); //значение должно(!) быть изменено внутри метода

        int counter;

        CharCounter("abcdbabababa", 'a', out counter);
        Console.WriteLine("counteer = " + counter);

    }

    //передача в метод массива параметров

    static int Sum(params int[] numbers)
    {
        int sum = 0;

        foreach (var item in numbers)
        {
            sum += item;
        }
        return sum;
    }

    static string[] GetNames( string name, params int[] numbers)
    {
        string[] result = new string[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            result[i] = name + "-" + numbers[i];
        }
        return result;
    }

    //без модификатора ref вхщдящее значение параметров не изменяется
    static void Clamp(int max, int value)
    {
        if (value > max) value = max;
    }

    //медификатор ref - передача параметра по ссылке
    static void Clamp(int max, ref int value)
    {
        if (value > max) value = max;
    }

    static void CharCounter(string str, char ch, out int count)
    {
        count = 0;

        foreach (var item in str)
        {
            if (item == ch)
            {
                count++;
            }
        }
    }
}

