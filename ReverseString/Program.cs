using System;
using System.Linq;


namespace ReverseString
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(new string(input.ToCharArray().Reverse().ToArray()));

        }
    }
}
