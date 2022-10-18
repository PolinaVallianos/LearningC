string name;
string number;
int JanCust, FebCust, MarCust, AprCust, MayCust, JuneCust, JulyCust;
string input;

Console.WriteLine("Enter the name of institutoin: ");
name = Console.ReadLine();
Console.WriteLine("Enter the name of institutoin: ");
number = Console.ReadLine();

Console.WriteLine("Enter the number of customers: ");
Console.Write("Jan: ");
input = Console.ReadLine();
JanCust = int.Parse(input);

Console.Write("Feb: ");
input = Console.ReadLine();
FebCust = int.Parse(input);

Console.Write("Mar: ");
input = Console.ReadLine();
MarCust = int.Parse(input);

Console.Write("Apr: ");
input = Console.ReadLine();
AprCust = int.Parse(input);

Console.Write("May: ");
input = Console.ReadLine();
MayCust = int.Parse(input);

Console.Write("June: ");
input = Console.ReadLine();
JuneCust = int.Parse(input);

Console.Write("July: ");
input = Console.ReadLine();
JulyCust = int.Parse(input);

float AverageCust = (JanCust + FebCust + MarCust + AprCust + MayCust + JuneCust + JulyCust) / 7f;

Console.WriteLine($"{name} N{number}.\nAverage: {AverageCust.ToString("#")}");

