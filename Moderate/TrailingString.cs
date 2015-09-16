using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                // do something with line
                if(line.ToLowerInvariant().Contains(',') && line.Length > 0)
                {
                bool isTrailing = CheckIfContainsTrailingString(line);
                Console.WriteLine(Convert.ToInt32(isTrailing));
                }
            }
    }
    static bool CheckIfContainsTrailingString(string line)
    {
        string[] bothStrings = line.Split(',');
        string originalString = bothStrings[0];
        string trailingString = bothStrings[1];
        List<char> newStringChars = new List<char>();

        int n = 0;
        while (newStringChars.Count != trailingString.Length)
        {
            if (originalString.Length - 1 - n < 0)
            {
                return false;
            }
            char c = originalString[originalString.Length - 1 - n];
            if (c != trailingString[trailingString.Length - 1 - n])
            {
                return false;
            }
            newStringChars.Add(c);
            n++;     
        }
        return true;
    }
}
        //Stack<char> reverseChars = new Stack<char>();
        //string[] theStrings = line.Split(',');
        //string originalString = theStrings[0];
        //string trailingString = theStrings[1];

        //char[] originalStringChars = originalString.ToCharArray();
        //char[] trailingStringChars = trailingString.ToCharArray();
        //int n = 1;
        //for (int i = originalStringChars.Length-1; i >= originalStringChars.Length - trailingStringChars.Length; i--)
        //{
        //    if (i >= originalStringChars.Length || i == -1)
        //    {
        //        return false;
        //    }
        //   char c = originalStringChars[i];
        //   if (trailingStringChars[trailingStringChars.Length - n] != c)
        //   {
        //       return false;
        //   }
        //   reverseChars.Push(c);
        //   n++;
        //}
        //string stackString = null;
        //while (reverseChars.Count > 0)
        //{
        //    stackString += reverseChars.Pop();
        //}

        //if (stackString == trailingString)
        //{
        //    return true;
        //}
        //else
        //{
        //    return false;
        //}
    //}
//}