﻿namespace Homework11;

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
        int Paragraphs = 1;
        {
            if (item.StartsWith('\n'))
            {
                Paragraphs += 1;
            }
        }


        
        string[] stringWords = str.Trim(' ').Split(' ','\n');
        int Words = stringWords.Length;

        
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
    }
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
    //}