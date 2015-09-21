using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

class Program
{
    private static StringBuilder textBuilder = new StringBuilder();
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                // do something with line
                string txtAmount = TextDollar(int.Parse(line));
                Console.WriteLine(txtAmount);
            }
    }
    static string TextDollar(int amount)
    {
        textBuilder.Clear();
        List<string> textBackWards = new List<string>();
        List<int> intToIgnore = new List<int>();
        if (amount == 1) { return "OneDollars"; }
        int startAmount = amount;
        int nextAmount = 0;
        int count = -1;
        string[] OneAmount = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] TenAmount = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        string[] Units = { "", "Thousand", "Million", "Billion" };

        while (amount >= 1)
        {
            if (amount % 1000 != 0)
            {
                nextAmount = amount % 1000;
                amount = amount / 1000;
            }
            else
            {
                while (amount >= 1000)
                {
                    amount = amount / 1000;
                    nextAmount = amount;
                    count++;
                    intToIgnore.Add(textBackWards.Count + (count+1));
                }
            }

            while (nextAmount != 0)
            {
                if (nextAmount <= 19)
                {
                    textBuilder.Append(OneAmount[nextAmount]);
                    nextAmount = 0;
                }
                else if (nextAmount <= 99)
                {
                    int firstDigit = nextAmount / 10;
                    textBuilder.Append(TenAmount[firstDigit]);
                    nextAmount %= 10;
                }
                else if (nextAmount >= 100)
                {
                    int firstDigit = nextAmount / 100;
                    textBuilder.Append((OneAmount[firstDigit] + "Hundred"));
                    nextAmount %= 100;
                }
            }
            count++;
            if (count <= 3)
            {
                textBackWards.Add(textBuilder.ToString() + Units[count]);
            }
            textBuilder.Clear();

        }
        for(int i = textBackWards.Count-1; i >= 0; i--)
        {
            if (!intToIgnore.Contains(i))
             {
                textBuilder.Append(textBackWards[i]);
            }
        }
        return textBuilder.ToString() +"Dollars";
    }
}