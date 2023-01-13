namespace Homework13;
[Flags]
enum Survey
{ 
    tasty = 2,
    unpalatable = 4,
    goodService = 8,
    badService = 16,
    inexpensively = 32,
    expencive = 64
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
                        survey = Survey.tasty;
                    }
                    break;
                case 1:
                    if (mark == "yes")
                    {
                        survey |= Survey.goodService;
                    }
                    break;
                default:
                    if (mark == "yes")
                    {
                        survey |= Survey.inexpensively;
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
        Survey[] goodChoices = new Survey[] {Survey.tasty, Survey.goodService,Survey.inexpensively};

        foreach (var item in goodChoices)
        {
            if (survey == (survey |= item))
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

