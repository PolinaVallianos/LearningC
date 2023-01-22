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

        CharCounter("abcdbabababa", 'a', out counter);//с помощью out можно передать не инициализированную переменную и изменится 
        Console.WriteLine("counteer = " + counter);

        if (CharCounter("abcdbabababa", 'a', out counter))
        {
            Console.WriteLine("counteer = " + counter);
        }

        if (CharCounter("abcdbabababa", 'm', out counter))
        {
            Console.WriteLine("counteer = " + counter);
        }

        Console.WriteLine("\n----- in modifier -----"); //значение не может(!) быть изменено быть изменено внутри метода

        //кортежи - набор сгруппированных значений
        Console.WriteLine("\n----- Tuples -----"); //значение не может(!) быть изменено быть изменено внутри метода

        (int, int) tuple1 = (2, 4);
        Console.WriteLine(tuple1);

        //по умолчаниюзначпния в кортеже имеют имена Item1, Item2, Item3..
        Console.WriteLine("tuple1.Item1 = " + tuple1.Item1);

        //также можно задавать и свои имена
        (string Name, int Age) person = ("Piter", 22);

        Console.WriteLine($"Name = {person.Name}, Age = {person.Age}");

        var vector2 = (X:0, Y:1);

        vector2.X = 12;
        vector2.Y = 5;

        vector2 = RandomMove();
        Console.WriteLine($"X: {vector2.X}; Y: {vector2.Y}");


        //объявление кортежа pair с элементами M и N
        (int M, int N) pair = (12, 13);

        //декомпазиция
        //объевление перемменных m и n, и присваеваем значения при помощи кортежа pair
        (int m, int n) = pair;

        //присваевание значений переменным a и b с помощью кортежа
        (a, b) = RandomMove();

        //обмен значений переменных с помощью кортежей
        Console.WriteLine($"m = {m}, n = {n}");
        (m, n) = (n, m);
        Console.WriteLine($"m = {m}, n = {n}");

        //при сравнении кортежей важны только тип и пордок значений
        vector2 = (12, 13);
        Console.WriteLine(pair == vector2);
        pair.M = 15;
        Console.WriteLine(pair == vector2);
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

    static bool CharCounter(string str, char ch, out int count)
    {
        bool result = false;
        count = 0;

        foreach (var item in str)
        {
            if (item == ch)
            {
                count++;
            }
        }

        if (count > 0) result = true;

        return result;
    }

    //кортеж как возращаемый тип
    static (int, int) RandomMove()
    {
        Random random = new Random();
        int x, y;
        x = random.Next(1000);
        y = random.Next(1000);

        return (x, y);
    }
}

