using System;

namespace BigOrLittleEndianess
{
    class Program
    {
        static void Main(string[] args)
        {
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
