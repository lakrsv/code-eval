using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText("sample.txt"))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                // do something with line
                string output = RemoveCharacters(line);
                Console.WriteLine(output);
                Console.ReadLine();
            }
    }
    static string RemoveCharacters(string line)
    {
        string[] theStrings = line.Split(',');
        string sentenceToModify = theStrings[0];
        char[] charsToRemove = theStrings[1].ToCharArray();

        string tempString = null;
        foreach (char character in charsToRemove)
        {
            if (character != ' ')
            {
                tempString += character;
            }
        }
        charsToRemove = tempString.ToCharArray();

        string stringToReturn = RemoveSpecificCharacters(sentenceToModify, charsToRemove);
        return stringToReturn;
    }
    static string RemoveSpecificCharacters(string sentence, char[] charsToRemove)
    {
        char[] charsInSentence = sentence.ToCharArray();
        string tempString = null;
        for (int i = 0; i < charsInSentence.Length; i++)
        {
            bool addCharToSentence = true;
            for (int k = 0; k < charsToRemove.Length; k++)
            {
                if (charsInSentence[i] == charsToRemove[k])
                {
                    addCharToSentence = false;
                }
            }
            if (addCharToSentence)
            {
                tempString += charsInSentence[i];
            }
        }
        return tempString;
    }
}
