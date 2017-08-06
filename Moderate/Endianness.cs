using System;

namespace BigOrLittleEndianess
{
    class Program
    {
        static void Main(string[] args)
        {
            //I know; It feels like cheating.
            //But you use the tools your language gives to you, KISS.
            bool isLittleEndian = BitConverter.IsLittleEndian;

            if (isLittleEndian)
            {
                Console.WriteLine("LittleEndian");
            }
            else
            {
                Console.WriteLine("BigEndian");
            }
        }
    }
}
