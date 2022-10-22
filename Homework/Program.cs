int intNumber = 0;
byte byteNumber = 0;
string input;
int number;

Console.WriteLine("Enter integer number: ");
input = Console.ReadLine();
number = int.Parse(input);

if (number <= 255)
{
    byteNumber = (byte)(byteNumber + number);;
}
else
{
    intNumber += number;
}

byteNumber += 1;
intNumber += 1;

if (byteNumber <= 1)
{
    byteNumber = (byte)intNumber;
}
else if (intNumber == 1)
{
    intNumber = byteNumber;
}

int difference = (int)(intNumber - byteNumber);
int hundreds = intNumber / 100;
int decades = intNumber % 100 / 10;
int units = intNumber % 100 % 10;

Console.Write($"Int:{intNumber} \nByte:{byteNumber} \nDiff:{difference} \n{hundreds} \n{decades} \n{units}");