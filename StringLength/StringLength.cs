using System;


namespace StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = input.PadRight(20, '*');
            Console.WriteLine(output);
        }
    }
}
