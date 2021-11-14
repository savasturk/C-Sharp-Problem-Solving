using System;

public class Frequencies {

  public static bool Frequencies(string input, string word1, string word2)
        {
            bool retValue = false;

            int countFirstWord = 0;
            int countSecondWord = 0;

            int i = 0;
            while((i = input.IndexOf(word1, i)) != -1)
            {
                i += word1.Length;
                countFirstWord++;
            }

            int j = 0;
            while ((j = input.IndexOf(word2, j)) != -1)
            {
                j += word2.Length;
                countSecondWord++;
            }

            if(countFirstWord == countSecondWord)
            {
                retValue = true;
            }
            else
            {
                retValue = false;
            }


            return retValue;
        }

    public static void Main() 
    {
        string test1 = "This is not";
        string test2 = "This is not not";
        string word1 = "is";
        string word2 = "not";

        Console.WriteLine(test1 + "  return: " + Frequencies(test1, word1, word2));
        Console.WriteLine(test2 + "  return: " + Frequencies(test2, word1, word2));
        Console.ReadLine();

    }
}