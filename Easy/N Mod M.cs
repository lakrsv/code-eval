using System;
using System.IO;
using System.Collections.Generic;

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
                float[] theNumbers = new float[2];
                string[] newString = line.Split(',');
                theNumbers[0] = int.Parse(newString[0]);
                theNumbers[1] = int.Parse(newString[1]);

                float modulo = FindModulo(theNumbers);
                Console.WriteLine(modulo);          
        }
    }
    public static float FindModulo(float[] numbers)
    {
        float N = numbers[0];
        float M = numbers[1];
        float StartM = M;
        if(M > N) { return N; }
        if(N == 0) { return 0; }
        if(M == N) { return 0; }

        while(M <= N)
        {
            M += StartM;
        }
        if(M == N)
        {
            return 0;
        }
        else
        {
            return N - (M - StartM);
        }
    }
}