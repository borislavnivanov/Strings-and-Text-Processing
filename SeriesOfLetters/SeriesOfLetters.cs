using System;

using System.Text;


namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            output.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i-1])
                {
                    output.Append(input[i]);
                }
            }
            Console.WriteLine(output);
        }
    }
}
