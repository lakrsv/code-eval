using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//Given a string S, and a list of strings of positive length, 
//F1,R1,F2,R2,...,FN,RN, proceed to find in order the occurrences(left-to-right)
//of Fi in S and replace them with Ri.All strings are over alphabet { 0, 1 }. 
//Searching should consider only contiguous pieces of S that have not been subject to
//replacements on prior iterations.An iteration of the algorithm should not write over
//any previous replacement by the algorithm.
//Input sample:

//Your program should accept as its first argument a path to a filename. 
//Each line in this file is one test case. Each test case will contain a string,
//then a semicolon and then a list of comma separated strings.E.g.
namespace CodeEval_StringSubstitution
{
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
                    string ToPrint = Substituted(line);
                    Console.WriteLine(ToPrint);

                }
        }
        static string Substituted(string line)
        {
            Random random = new Random();
            string[] allStrings;
            string mainString;
            string[] substitutors;
            List<ReplacePairs> replacePairs = new List<ReplacePairs>();

            //Find the main string, divided by ;
            allStrings = line.Split(';');
            mainString = allStrings[0];
            substitutors = allStrings[1].Split(',');

            //Add the replacepairs to the replacepair list.
            for (int i = 0; i < substitutors.Length-1; i += 2)
            {
                ReplacePairs pair = new ReplacePairs(substitutors[i], substitutors[i + 1], IDGenerator(random));
                replacePairs.Add(pair);
            }

            //Create the stringbuilder for creating a new string.
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mainString);

            int lastPairIndex = 0;
            foreach (ReplacePairs pair in replacePairs)
            {
                //Replace the occurence with a temporary ID so that the other pairs can't find it and replace it.
                stringBuilder.Replace(pair.toReplace, pair.tempID);
            }
            //When done, replace all the tempIDs with the actual toReplaceWith.
            foreach (ReplacePairs pair in replacePairs)
            {
                stringBuilder.Replace(pair.tempID, pair.toReplaceWith);
            }
            return stringBuilder.ToString();

        }
        public static string IDGenerator(Random random)
        {
            string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            List<char> chars = new List<char>();
            chars.Add('|');
            for (int i = 0; i < 20; i++)
            {
                char _char = input[random.Next(0, input.Length)];
                chars.Add(_char);
            }
            chars.Add('|');

            return new string(chars.ToArray());
        }
    }
    class ReplacePairs
    {
        public string tempID;
        public string toReplace;
        public string toReplaceWith;
        public ReplacePairs(string toreplace, string toreplacewith, string tempid)
        {
            toReplace = toreplace;
            toReplaceWith = toreplacewith;
            tempID = tempid;

        }
    }
}