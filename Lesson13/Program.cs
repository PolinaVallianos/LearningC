namespace Lesson13;

//Перечесление - набор именновоных констант
enum Color
{
    Unknown,    // = 0 - значение по умолчанию
    Red,        // = 1
    Green,      // = 2
    Blue        // = 3
}

// можно задавать любые числовые значения для каждой константы
enum DecimaPlace
{
    Ones = 1,
    Tens = 10,
    Hundreds = 100,
    Thousends = 1000
}

//числовые значения продолжатся с последнего назначенного номера и могут повторяться
//несколько констант могут иметь одинаковое числовое значение
enum MyEnum
{
    One = 1,
    Two,        // = 2
    Three,      // = 3
    Four = 8,   
    Five,       // = 9
    Six,        // = 10
    Seven = 0,
    Eight,      // = 1
    Nine,       // = 2
    Ten = Four  // = 8
}

//Битовые флаги
//Неисключающие перечесления - перечесления, которые могут хранить несколько значений одновременно

[Flags]
enum DaysOfWeek
{
    Monday = 1,     //00000001
    Tuesday = 2,    //00000010
    Wednesday = 4,  //00000100
    Thursday = 8,   //00001000
    Friday = 16,    //00010000
    Saturday = 32,  //00100000
    Sunday = 64,    //01000000

    //часто используемые значения можно объединить в дополнительные константы
    WorkDays = Monday | Tuesday | Wednesday | Thursday | Friday, //00011111
    Weekend = Saturday | Sunday //01100000

}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a color: Red - 1, Green - 2, Blue - 3");

        int colorNumber = int.Parse(Console.ReadLine());

        Console.Write("\nYour color: ");
        switch (colorNumber)
        {
            case 1:
                Console.Write("Red");
                break;
            case 2:
                Console.Write("Green");
                break;
            case 3:
                Console.Write("Blue");
                break;
            default:
                break;
        }


        Color myColor;
        myColor = new Color(); //задается значение 0

        //задаем значение переменной
        switch (colorNumber)
        {
            case 1:
                myColor = Color.Red;
                break;
            case 2:
                myColor = Color.Green;
                break;
            case 3:
                myColor = Color.Blue;
                break;
            default:
                myColor = Color.Unknown;
                break;
        }

        switch (myColor)
        {
            case Color.Red:
                Console.WriteLine("Red");
                break;
            case Color.Green:
                Console.WriteLine("Green");
                break;
            case Color.Blue:
                Console.WriteLine("Blue");
                break;
            default:
                Console.WriteLine("Unknown");
                break;
        }

        //задаем значение перечесления с помощью числового константы
        myColor = (Color)colorNumber;
        Console.WriteLine("\nYour color: ");
        switch (myColor)
        {
            case Color.Red:
                Console.WriteLine("Red");
                break;
            case Color.Green:
                Console.WriteLine("Green");
                break;
            case Color.Blue:
                Console.WriteLine("Blue");
                break;
            default:
                Console.WriteLine("Unknown");
                break;
        }


        //проверяем соответствует ли числу colorNumber какая-либо константа типа Color
        myColor = Enum.IsDefined((Color)colorNumber) ? (Color)colorNumber : Color.Unknown;

        //вывести имя константы
        Console.WriteLine("\nYour color: " + myColor);

        //выводим числовое значение
        Console.WriteLine("\nYour color number: " + (int)myColor);

        Console.WriteLine();

        Random random = new Random();
        int x = random.Next(10000);

        Console.Write($"""
            Number {x} contains:
            {x/(int)DecimaPlace.Thousends} Thousends
            {x/(int)DecimaPlace.Hundreds} Hundreds
            {x/(int)DecimaPlace.Tens} Tens
            {x} Ones
            """);

        Console.WriteLine("\n");

        //сохраняем в переменную 2 значения
        DaysOfWeek gymDay = DaysOfWeek.Monday | DaysOfWeek.Wednesday;

        Console.WriteLine(gymDay);

        //добавляем значение в переменную
        gymDay = gymDay | DaysOfWeek.Friday;
        gymDay |= DaysOfWeek.Friday;

        Console.WriteLine(gymDay);

        //удаляем значение
        gymDay ^= DaysOfWeek.Friday; //gymDay = gymDay ^ DaysOfWeek.Friday;
        Console.WriteLine(gymDay);

        //удаляем значение кроме какого-то
        gymDay &= DaysOfWeek.Monday;
        Console.WriteLine(gymDay);

        //присваиваем все рабочие дни кроме Среды
        gymDay = DaysOfWeek.WorkDays ^ DaysOfWeek.Wednesday;
        Console.WriteLine(gymDay);

        //присваиваем все выходные дни и Среда
        gymDay = DaysOfWeek.Weekend | DaysOfWeek.Wednesday;
        Console.WriteLine(gymDay);

        if (gymDay.HasFlag(DaysOfWeek.Wednesday)) //содержится ли Среда в днях тренеровок
        {
            Console.WriteLine("Wendnesday is a gym day");
        }

        var today = DaysOfWeek.Wednesday;

        if (gymDay.HasFlag(today)) //содержится ли сегодняшний день в днях тренеровок
        {
            Console.WriteLine("Go to the gym");
        }
    }
}

