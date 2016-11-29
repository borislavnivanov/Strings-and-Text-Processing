using System;


namespace Sub_stringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string target = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();

            int counter = 0;
            int index = 0;

            while (true)
            {
                int found = input.IndexOf(target, index);
                if (found < 0)
                {
                    break;
                }
                counter++;
                index = found + 1;

            }
            Console.WriteLine(counter);
        }
    }
}
