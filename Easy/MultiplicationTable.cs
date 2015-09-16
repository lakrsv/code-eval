using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mod = 0;
            string line = null;
            for (int i = 1; i <= 12; i++)
            {
                for (int k = 1; k <= 12; k++)
                {
                    if (line == null)
                    {
                        line += i;
                    }
                    else
                    {
                        string toPrint = null;
                        if (i * k < 10)
                        {
                            toPrint = "   " + i * k;
                        }
                        else if (i * k < 100)
                        {
                            toPrint = "  " + i * k;
                        }
                        else
                        {
                            toPrint = " " + i * k;
                        }
                        line += toPrint;
                    }
                    mod++;
                }
                Console.WriteLine(line);
                line = null;
                Console.ReadLine();
            }
        }
    }
}
