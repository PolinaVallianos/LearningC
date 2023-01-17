namespace Homework13;
[Flags]
enum Survey
{
    Tasty = 1,
    GoodService = 2,
    Inexpensively = 4
}

enum Stars
{
    Zero,
    One,
    Two,
    Three
}

class Program
{
    static void Main(string[] args)
    {
        Survey survey;
        survey = new Survey();
        string mark;
        string[] questions = new string[] { "Was it delicious?", "Good service?", "Not expensive?" };

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);
            mark = Console.ReadLine();

            switch (i)
            {
                case 0:
                    if (mark == "yes")
                    {
                        survey |= Survey.Tasty;
                    }
                    break;
                case 1:
                    if (mark == "yes")
                    {
                        survey |= Survey.GoodService;
                    }
                    break;
                default:
                    if (mark == "yes")
                    {
                        survey |= Survey.Inexpensively;
                    }
                    break;
            }
        }

        Console.WriteLine("Servey: " + survey);
        Console.WriteLine("Stars: " + SetStars(survey));
    }

    static Stars SetStars(Survey survey)
    {
        int stars = 0;
        Survey[] goodChoices = new Survey[] {Survey.Tasty, Survey.GoodService,Survey.Inexpensively};

        foreach (var item in goodChoices)
        {
            if (survey.HasFlag(item))
            {
                stars++;
            }
        }

        switch (stars)
        {
            case 1:
                return Stars.One;
                break;
            case 2:
                return Stars.Two;
                break;
            case 3:
                return Stars.Three;
                break;
            default:
                return Stars.Zero;
                break;
        }
    }
}

