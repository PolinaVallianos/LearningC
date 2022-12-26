namespace Homework11;class Program{    static void Main(string[] args)    {        string input = "What, exactly is Good and Bad? We say things are good and bad but how do we decide this?\n" +            "Bad is defined as the opposite of good, so this means something assessed as such is unfit or morally reprehensible.\n" +            "when something is moral, we say an act is good or bad. We also may say that the person is good or bad, although this implies that a person who does one bad thing has permanently bad intent and will always do bad things, and vice versa.\n" +            "This makes good and bad uniquely human. Animals do not have morals, so predatory and possibly cruel (in our view) acts are neither good nor bad. We cannot say, for example, that a lion which kills a terrified buffalo is bad (or good).\n" +            "Deciding whether something is good or bad is an evaluation, a decision. the concept of good and bad is important in our decision-making and we use our notions of goodness to censor both our own choices and those of others.\n" +            "good and bad are defined by people. When nobody knows and there is nobody there to judge, then good and bad do not inherently exist.\n" +            "Some who wear the goodguy badge are also actually good people.";        Statistics(input);        Console.WriteLine("Number of bad = " + NumberOfBad(input));        //Console.WriteLine(Censor(input));    }    static void Statistics(string str)    {

        Console.WriteLine($"Characters = {str.Length}");
        //Буквы
        int Signs = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '.' || str[i] == ',' || str[i] == ' ' || str[i] == '\n' || str[i] == '?' || str[i] == '(' || str[i] == ')' || str[i] == '-')
            {
                Signs += 1;
            }
        }

        Console.WriteLine($"Letters = {str.Length - Signs}");
        //Предложения
        str = str.Replace('?', '.');

        string[] stringOffers = str.Trim(' ','.').Split('.');
        int Offers = stringOffers.Length;

        //Обзацы
        int Paragraphs = 1;        foreach (var item in stringOffers)
        {
            if (item.StartsWith('\n'))
            {
                Paragraphs += 1;
            }
        }


        
        string[] stringWords = str.Trim(' ').Split(' ','\n');
        int Words = stringWords.Length;

                Console.WriteLine($"Words = {Words}");        Console.WriteLine($"Offers = {Offers}");        Console.WriteLine($"Paragraphs = {Paragraphs}");    }    static int NumberOfBad(string str)
    {
        int numberOf_bad = 0;
        int startIndex = 0;

        while (str.ToLower().IndexOf("bad", startIndex) > 0)
        {
            startIndex = str.ToLower().IndexOf("bad", startIndex);
            startIndex++;
            numberOf_bad++;

        }

        return numberOf_bad;
    }    //static string Censor(string str)
    //{
    //    string[] newstr = str.Trim('.', ',', '?', '\n').Split(' ');

    //    for (int i = 0; i < newstr.Length; i++)
    //    {
    //        if (newstr[i] == "bad")
    //        {
    //            newstr[i] = "good";
    //        }
    //        else
    //        {
    //            if (newstr[i] == "good")
    //            {
    //                newstr[i] = "bad";
    //            }
    //        }
    //    }

    //    string newString = "";
    //    foreach (var item in newstr)
    //    {
    //        newString += item + ' ';
    //        if (item.EndsWith(('\n'))
    //        {
    //            item + 1
    //        }
    //    }

    //    return newString;
    //}}