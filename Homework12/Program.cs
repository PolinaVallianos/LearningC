using System.Text;
using Microsoft.VisualBasic;

namespace Homework12;
class Program
{
    static void Main(string[] args)
    {
        string input = @"input.txt";

        string out1 = @"Output/numbers100-199.txt";
        string out2 = @"Output/numbers200-299.txt";
        string out3 = @"Output/numbers300-399.txt";

        CreateInput(input);
        Separator(input, out1, out2, out3);
    }

    static void CreateInput(string input)
    {
        string[] Array = new string[1000];
        Random rand = new Random();

        for (int i = 0; i < Array.Length; i++)
        {
            int x = rand.Next(100, 400);
            Array[i] = x.ToString();
        }
        File.WriteAllLines(input, Array);
    }

    static void Separator(string input, string out1, string out2, string out3)
    {
        string text = File.ReadAllText(input);
        string[] textNew = text.Split('\n');
        StringBuilder out11 = new StringBuilder();
        StringBuilder out22 = new StringBuilder();
        StringBuilder out33 = new StringBuilder();
        int a = 0;
        int b = 0;
        int c = 0;

        for (int i = 0; i < 1000; i++)
        {

            if (textNew[i].StartsWith('1'))
            {
                out11.Append(textNew[i] + " ");
                a++;

                if (a == 10)
                {
                    out11.Append('\n');
                    a = 0;
                }
            }

            if (textNew[i].StartsWith('2'))
            {
                out22.Append(textNew[i] + " ");
                b++;

                if (b == 10)
                {
                    out22.Append('\n');
                    b = 0;
                }
            }

            if (textNew[i].StartsWith('3'))
            {
                out33.Append(textNew[i] + " ");
                c++;

                if (c == 10)
                {
                    out33.Append('\n');
                    c = 0;
                }
            }
        }
        File.WriteAllText(out1, out11.ToString());
        File.WriteAllText(out2, out22.ToString());
        File.WriteAllText(out3, out33.ToString());

        //string[] text1 = out11.ToString().Split('\n');
        //string[] text2 = out22.ToString().Split('\n');
        //string[] text3 = out33.ToString().Split('\n');

        //File.WriteAllLines(out1, text1);
        //File.WriteAllLines(out2, text2);
        //File.WriteAllLines(out3, text3);
    }
}