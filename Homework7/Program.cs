using System.Xml.Linq;

namespace Homework7;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter task number: ");
        var value = Console.ReadLine();
        WhatType();
    }

    static string WhatType(int value)
    {
        return $"{value} is of 'int' type";

    }


    static string WhatType(float value)
    {
        return $"{value} is of 'float' type";

    }



    static dynamic WhatType(string type = "n", int value = 0)
    {
        switch (type)
        {
            case "n":
                return IntType(value);
            case "f":
                return FloatType(value);
            default:
                return 0;
        }
    }
    static int IntType(int number)
    {
        Console.WriteLine($"{number} of int type");
        return number;
    }

    static float FloatType(float number)
    {
        Console.WriteLine($"{number} of float type");
        string FloatType = "Float Type";
        return number;

    }


}